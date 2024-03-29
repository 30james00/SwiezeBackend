using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Contacts
{
    public record DeleteContactCommand() : IRequest<ApiResult<Unit>>;

    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;

        public DeleteContactCommandHandler(DataContext context, IUserAccessor userAccessor)
        {
            _context = context;
            _userAccessor = userAccessor;
        }

        public async Task<ApiResult<Unit>> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            var userId = _userAccessor.GetUserId();

            if (userId == null)
                return ApiResult<Unit>.Failure("Failed to create new Contact - user not found");

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(x => x.AccountId == userId, cancellationToken);

            if (contact == null) return null;

            _context.Contacts.Remove(contact);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to delete the contact");
        }
    }
}