using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Products.EditProduct
{
    public class EditProductCommand : IRequest<ApiResult<ProductDto>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Unit { get; set; }
        public int Stock { get; set; }
        public Guid UnitTypeId { get; set; }
        public List<Guid> Categories { get; set; }
    }

    public class EditProductCommandHandler : IRequestHandler<EditProductCommand, ApiResult<ProductDto>>
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;
        private readonly IMapper _mapper;

        public EditProductCommandHandler(DataContext context, IUserAccessor userAccessor, IMapper mapper)
        {
            _context = context;
            _userAccessor = userAccessor;
            _mapper = mapper;
        }

        public async Task<ApiResult<ProductDto>> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Id);

            if (product == null) return ApiResult<ProductDto>.Failure("Chosen Product doesn't exist");

            //get and check VendorId
            var userId = _userAccessor.GetUserId();
            if (userId == null) return ApiResult<ProductDto>.Failure("Failed to edit new Product - user not found");
            var vendorId = await _context.Vendors.Where(x => x.AccountId == userId).Select(x => x.Id)
                .FirstOrDefaultAsync(cancellationToken);
            if (vendorId == Guid.Empty)
                return ApiResult<ProductDto>.Failure("Failed to edit new Product - user is not Vendor");

            if (product.VendorId != vendorId) return ApiResult<ProductDto>.Forbidden();

            var productCategories = new List<ProductCategory>();

            var categories = _context.Categories.Select(x => x.Id).ToList();
            var unitType = await _context.UnitTypes.Select(x => x.Id)
                .FirstOrDefaultAsync(x => x == request.UnitTypeId, cancellationToken: cancellationToken);

            if (unitType == Guid.Empty) return ApiResult<ProductDto>.Failure("Chosen UnitType doesn't exist");

            //remove existing ProductCategories
            var productCategoriesToDelete =
                await _context.ProductCategories.Where(x => x.ProductId == request.Id).ToListAsync(cancellationToken);
            _context.ProductCategories.RemoveRange(productCategoriesToDelete);

            //add new ProductCategories
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

            product.Name = request.Name;
            product.Value = request.Value;
            product.Unit = request.Unit;
            product.Stock = request.Stock;
            product.UnitTypeId = request.UnitTypeId;
            product.ProductCategories = productCategories;

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<ProductDto>.Success(_mapper.Map<ProductDto>(product))
                : ApiResult<ProductDto>.Failure("Failed to edit Product");
        }
    }
}