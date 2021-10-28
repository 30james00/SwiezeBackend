using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Products
{
    public record ListProductQuery(PagingParams Params) : IRequest<ApiResult<PagedList<ProductDto>>>;

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

            return ApiResult<PagedList<ProductDto>>.Success(
                await PagedList<ProductDto>.CreateAsync(query, request.Params.PageNumber, request.Params.PageSize));
        }
    }
}