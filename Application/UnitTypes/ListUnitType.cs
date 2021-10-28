using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Categories;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.UnitTypes
{
    public record ListUnitTypeQuery() : IRequest<ApiResult<List<UnitTypeDto>>>;

    public class ListUnitTypeQueryHandler : IRequestHandler<ListUnitTypeQuery, ApiResult<List<UnitTypeDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ListUnitTypeQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<List<UnitTypeDto>>> Handle(ListUnitTypeQuery request,
            CancellationToken cancellationToken)
        {
            return ApiResult<List<UnitTypeDto>>.Success(await _context.UnitTypes
                .ProjectTo<UnitTypeDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken));
        }
    }
}