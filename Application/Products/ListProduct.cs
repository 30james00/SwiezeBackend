using System.Linq;
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
        (PagingParams PagingParams, SortingParams SortingParams) : IRequest<ApiResult<PagedList<ProductDto>>>;

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
            
            query = request.SortingParams.GetData(query);

            return ApiResult<PagedList<ProductDto>>.Success(
                await PagedList<ProductDto>.CreateAsync(query, request.PagingParams.PageNumber,
                    request.PagingParams.PageSize));
        }
    }
}