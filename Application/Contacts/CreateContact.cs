using System.Data;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Domain;
using FluentValidation;
using MediatR;
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

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<ApiResult<Contact>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Contacts.Add(request.Contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (!result) return ApiResult<Contact>.Failure("Failed to create new Contact");
                return ApiResult<Contact>.Success(request.Contact);
            }
        }
    }
}