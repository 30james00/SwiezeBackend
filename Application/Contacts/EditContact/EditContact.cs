using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Contacts.EditContact
{

        public class EditContactCommand : IRequest<ApiResult<Unit>>
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

        public class EditContactCommandHandler : IRequestHandler<EditContactCommand, ApiResult<Unit>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            private readonly IUserAccessor _userAccessor;

            public EditContactCommandHandler(DataContext context, IMapper mapper, IUserAccessor userAccessor)
            {
                _context = context;
                _mapper = mapper;
                _userAccessor = userAccessor;
            }

            public async Task<ApiResult<Unit>> Handle(EditContactCommand request, CancellationToken cancellationToken)
            {
                var contact = await _context.Contacts.FirstOrDefaultAsync(x => x.AccountId == _userAccessor.GetUserId(),
                    cancellationToken);

                if (contact == null) return null;

                _mapper.Map(request, contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                return result
                    ? ApiResult<Unit>.Success(Unit.Value)
                    : ApiResult<Unit>.Failure("Failed to edit the Contact");
            }
        }
}