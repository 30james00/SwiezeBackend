using System;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;

namespace Application.Products
{
    public record ListProductQuery
        (ProductParams ProductParams, SortingParams SortingParams) : IRequest<ApiResult<PagedList<ProductDto>>>;

    public class ListProductQueryHandler : IRequestHandler<ListProductQuery, ApiResult<PagedList<ProductDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ListProductQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<PagedList<ProductDto>>> Handle(ListProductQuery request,
            CancellationToken cancellationToken)
        {
            var query = _context.Products.ProjectTo<ProductDto>(_mapper.ConfigurationProvider).AsQueryable();

            //Name filter
            if (request.ProductParams.Name != null)
                query = query.Where(x => x.Name.ToLower() == request.ProductParams.Name.ToLower());
            
            //Vendor filter
            if (request.ProductParams.Vendor != null)
                query = query.Where(x => x.VendorId == request.ProductParams.Vendor);

            //Value filter
            if (request.ProductParams.MinValue != 0)
                query = query.Where(x =>
                    x.Value >= request.ProductParams.MinValue);
            if (request.ProductParams.MaxValue != 0)
                query = query.Where(x =>
                    x.Value <= request.ProductParams.MaxValue);

            //Unit filter
            if (request.ProductParams.MinUnit != 0)
                query = query.Where(x =>
                    x.Unit >= request.ProductParams.MinUnit);
            if (request.ProductParams.MaxUnit != 0)
                query = query.Where(x =>
                    x.Unit <= request.ProductParams.MaxUnit);

            //Category filter
            if (request.ProductParams.Category != Guid.Empty)
                query = query.Where(x => x.Categories.Contains(request.ProductParams.Category));

            //Sort
            query = request.SortingParams.GetData(query);

            return ApiResult<PagedList<ProductDto>>.Success(
                await PagedList<ProductDto>.CreateAsync(query, request.ProductParams.PageNumber,
                    request.ProductParams.PageSize));
        }
    }
}