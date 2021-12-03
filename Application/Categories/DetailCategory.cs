using System;
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
    public record DetailCategoryQuery(Guid Id) : IRequest<ApiResult<CategoryDto>>;

    public class DetailCategoryQueryHandler : IRequestHandler<DetailCategoryQuery, ApiResult<CategoryDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DetailCategoryQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<ApiResult<CategoryDto>> Handle(DetailCategoryQuery request, CancellationToken cancellationToken)
        {
            return ApiResult<CategoryDto>.Success(
                await _context.Categories.ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken));
        }
    }
}