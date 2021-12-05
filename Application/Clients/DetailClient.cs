using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Clients
{
    public record DetailClientQuery(Guid Id) : IRequest<ApiResult<ClientDto>>;

    public class DetailClientQueryHandler : IRequestHandler<DetailClientQuery, ApiResult<ClientDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DetailClientQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<ClientDto>> Handle(DetailClientQuery request, CancellationToken cancellationToken)
        {
            return ApiResult<ClientDto>.Success(await _context.Clients
                .ProjectTo<ClientDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken));
        }
    }
}