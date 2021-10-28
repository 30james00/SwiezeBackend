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

namespace Application.Categories
{
    public record ListCategoryQuery() : IRequest<ApiResult<List<CategoryDto>>>;

    public class ListCategoryQueryHandler : IRequestHandler<ListCategoryQuery, ApiResult<List<CategoryDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ListCategoryQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<CategoryDto>>> Handle(ListCategoryQuery request,
            CancellationToken cancellationToken)
        {
            return ApiResult<List<CategoryDto>>.Success(await _context.Categories
                .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken));
        }
    }
}