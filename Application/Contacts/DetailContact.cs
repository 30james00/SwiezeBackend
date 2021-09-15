using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.Contacts
{
    public class DetailContact
    {
        public record Query(Guid Id) : IRequest<ApiResult<Contact>>;
        
        public class Handler : IRequestHandler<Query, ApiResult<Contact>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            
            public async Task<ApiResult<Contact>> Handle(Query request, CancellationToken cancellationToken)
            { 
                return ApiResult<Contact>.Success(await _context.Contacts.FindAsync(request.Id));
            }
        }
    }
}