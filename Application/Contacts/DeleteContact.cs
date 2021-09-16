using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Contacts
{
    public class DeleteContact
    {
        public record Command(Guid id) : IRequest<ApiResult<Unit>>;

        public class Handler : IRequestHandler<Command, ApiResult<Unit>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<ApiResult<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var contact = await _context.Contacts.FindAsync(request.id);

                if (contact == null) return null;

                _context.Remove(contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                return result
                    ? ApiResult<Unit>.Success(Unit.Value)
                    : ApiResult<Unit>.Failure("Failed to delete the contact");
            }
        }
    }
}