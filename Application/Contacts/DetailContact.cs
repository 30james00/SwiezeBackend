using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Contacts
{
    public class DetailContact
    {
        public record Query(Guid Id) : IRequest<Contact>;
        
        public class Handler : IRequestHandler<Query, Contact>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            
            public async Task<Contact> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Contacts.FindAsync(request.Id);
            }
        }
    }
}