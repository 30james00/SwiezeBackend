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
        public record DetailContactQuery(Guid Id) : IRequest<ApiResult<ContactDto>>;

        public class DetailContactQueryHandler : IRequestHandler<DetailContactQuery, ApiResult<ContactDto>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public DetailContactQueryHandler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ApiResult<ContactDto>> Handle(DetailContactQuery request, CancellationToken cancellationToken)
            {
                return ApiResult<ContactDto>.Success(await _context.Contacts
                    .ProjectTo<ContactDto>(_mapper.ConfigurationProvider)
                    .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken: cancellationToken));
            }
        }
}