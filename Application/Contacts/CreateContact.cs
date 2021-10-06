using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using Domain;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Contacts
{
    public class CreateContact
    {
        public record Command(Contact Contact) : IRequest<ApiResult<Contact>>;

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Contact).SetValidator(new ContactValidator());
            }
        }

        public class Handler : IRequestHandler<Command, ApiResult<Contact>>
        {
            private readonly DataContext _context;
            private readonly IUserAccessor _userAccessor;

            public Handler(DataContext context, IUserAccessor userAccessor)
            {
                _context = context;
                _userAccessor = userAccessor;
            }

            public async Task<ApiResult<Contact>> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == _userAccessor.GetUsername(),
                    cancellationToken: cancellationToken);

                request.Contact.Vendor = await _context.Vendors.FirstOrDefaultAsync(x => x.Account == user, cancellationToken: cancellationToken);

                _context.Contacts.Add(request.Contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (!result) return ApiResult<Contact>.Failure("Failed to create new Contact");
                return ApiResult<Contact>.Success(request.Contact);
            }
        }
    }
}