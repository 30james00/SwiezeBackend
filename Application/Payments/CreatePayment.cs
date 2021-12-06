using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using MediatR;

namespace Application.Payments
{
    public record CreatePaymentQuery(Guid Id) : IRequest<ApiResult<string>>;
    
    public class CreatePaymentQueryHandler : IRequestHandler<CreatePaymentQuery, ApiResult<string>>
    {
        public Task<ApiResult<string>> Handle(CreatePaymentQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}