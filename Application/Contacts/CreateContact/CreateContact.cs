using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Contacts.CreateContact
{
    public class CreateContact
    {
        public class Command : IRequest<ApiResult<ContactDto>>
        {
            public string Mail { get; set; }
            public string Phone { get; set; }
            public string Voivodeship { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string HouseNumber { get; set; }
            public string FlatNumber { get; set; }
        }

        public class Handler : IRequestHandler<Command, ApiResult<ContactDto>>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IUserAccessor userAccessor, IMapper mapper)
            {
                _context = context;
                _userAccessor = userAccessor;
                _mapper = mapper;
            }

            public async Task<ApiResult<ContactDto>> Handle(Command request, CancellationToken cancellationToken)
            {
                var userId = _userAccessor.GetUserId();

                if (userId == null)
                    return ApiResult<ContactDto>.Failure("Failed to create new Contact - user not found");

                if (await _context.Contacts.FirstOrDefaultAsync(x => x.AccountId == userId, cancellationToken) != null)
                {
                    return ApiResult<ContactDto>.Failure("Failed to create new Contact - user already exists");
                }
                    
                var contact = _mapper.Map<Contact>(request);

                contact.AccountId = userId;

                _context.Contacts.Add(contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                return !result
                    ? ApiResult<ContactDto>.Failure("Failed to create new Contact")
                    : ApiResult<ContactDto>.Success(_mapper.Map<ContactDto>(contact));
            }
        }
    }
}