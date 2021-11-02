using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Products.CreateProduct
{
    public class CreateProductCommand : IRequest<ApiResult<ProductDto>>
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Unit { get; set; }
        public int Stock { get; set; }
        public Guid UnitTypeId { get; set; }
        public List<Guid> Categories { get; set; }
    }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ApiResult<ProductDto>>
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(DataContext context, IUserAccessor userAccessor, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _userAccessor = userAccessor;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<ProductDto>> Handle(CreateProductCommand request,
            CancellationToken cancellationToken)
        {
            //get and check VendorId
            var accountInfo = await _accountService.GetAccountInfo();
            if (accountInfo.AccountType != AccountType.Vendor)
                return ApiResult<ProductDto>.Failure("Failed to create new Product - user is not Vendor");

            var productCategories = new List<ProductCategory>();

            var categories = _context.Categories.Select(x => x.Id).ToList();
            var unitType = await _context.UnitTypes.Select(x => x.Id)
                .FirstOrDefaultAsync(x => x == request.UnitTypeId, cancellationToken: cancellationToken);

            if (unitType == Guid.Empty) return ApiResult<ProductDto>.Failure("Chosen UnitType doesn't exist");

            var product = new Product
            {
                Name = request.Name,
                Value = request.Value,
                Unit = request.Unit,
                Stock = request.Stock,
                UnitTypeId = request.UnitTypeId,
                VendorId = accountInfo.Id,
                ProductCategories = productCategories,
            };

            foreach (var id in request.Categories)
            {
                if (categories.Contains(id))
                {
                    productCategories.Add(new ProductCategory
                    {
                        CategoryId = id,
                        ProductId = product.Id,
                    });
                }
                else return ApiResult<ProductDto>.Failure("Chosen Category doesn't exist");
            }

            await _context.ProductCategories.AddRangeAsync(productCategories, cancellationToken);
            await _context.Products.AddAsync(product, cancellationToken);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<ProductDto>.Success(_mapper.Map<ProductDto>(product))
                : ApiResult<ProductDto>.Failure("Failed to add Product to DB");
        }
    }
}