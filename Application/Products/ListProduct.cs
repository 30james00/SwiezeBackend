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
    public record ListProductQuery() : IRequest<ApiResult<List<ProductDto>>>;

    public class ListProductQueryHandler : IRequestHandler<ListProductQuery, ApiResult<List<ProductDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ListProductQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<ProductDto>>> Handle(ListProductQuery request,
            CancellationToken cancellationToken)
        {
            var contacts = await _context.Products.ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return ApiResult<List<ProductDto>>.Success(contacts);
        }
    }
}