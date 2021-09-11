using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Contacts
{
    public class CreateContact
    {
        public record Command(Contact Contact) : IRequest<Contact>;

        public class Handler: IRequestHandler<Command, Contact>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            
            public async Task<Contact> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Contacts.Add(request.Contact);
                await _context.SaveChangesAsync(cancellationToken);
                return request.Contact;
            }
        }
    }
}