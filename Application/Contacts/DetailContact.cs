using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Contacts
{
    public class DetailContact
    {
        public record Query(Guid Id) : IRequest<ApiResult<ContactDto>>;

        public class Handler : IRequestHandler<Query, ApiResult<ContactDto>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ApiResult<ContactDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                return ApiResult<ContactDto>.Success(await _context.Contacts
                    .ProjectTo<ContactDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken));
            }
        }
    }
}