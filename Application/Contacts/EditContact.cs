using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Contacts
{
    public class EditContact
    {
        public record Command(Guid Id, Contact Contact) : IRequest<ApiResult<Unit>>;

        public class Handler : IRequestHandler<Command, ApiResult<Unit>>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<ApiResult<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var contact = await _context.Contacts.FindAsync(request.Id);

                if (contact == null) return null;

                _mapper.Map(request.Contact, contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                return result
                    ? ApiResult<Unit>.Success(Unit.Value)
                    : ApiResult<Unit>.Failure("Failed to edit the Contact");
            }
        }
    }
}