using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.UnitTypes
{
    public record DetailUnitTypeQuery(Guid Id) : IRequest<ApiResult<UnitTypeDto>>;
    
    public class DetailUnitTypeQueryHandler : IRequestHandler<DetailUnitTypeQuery, ApiResult<UnitTypeDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DetailUnitTypeQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        public async Task<ApiResult<UnitTypeDto>> Handle(DetailUnitTypeQuery request, CancellationToken cancellationToken)
        {
            return ApiResult<UnitTypeDto>.Success(
                await _context.UnitTypes.ProjectTo<UnitTypeDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken));
        }
    }
}