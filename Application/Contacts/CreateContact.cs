using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Contacts
{
    public class CreateContact
    {
        public record Command(Contact Contact) : IRequest<ApiResult<ContactDto>>;

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Contact).SetValidator(new ContactValidator());
            }
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
                var user = await _context.Users.Include(x => x.Client).Include(x => x.Vendor).FirstOrDefaultAsync(
                    x => x.UserName == _userAccessor.GetUsername(),
                    cancellationToken: cancellationToken);

                if (user == null) return ApiResult<ContactDto>.Failure("Failed to create new Contact - user not found");

                if (user.Client != null)
                {
                    request.Contact.Client = user.Client;
                }
                else
                {
                    request.Contact.Vendor = user.Vendor;
                }

                _context.Contacts.Add(request.Contact);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                return !result
                    ? ApiResult<ContactDto>.Failure("Failed to create new Contact")
                    : ApiResult<ContactDto>.Success(_mapper.Map<ContactDto>(request.Contact));
            }
        }
    }
}