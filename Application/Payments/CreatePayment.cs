using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using Application.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Payments
{
    public record CreatePaymentQuery(Guid Id) : IRequest<ApiResult<string>>;

    public class CreatePaymentQueryHandler : IRequestHandler<CreatePaymentQuery, ApiResult<string>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IPaymentsAccessor _paymentsAccessor;

        public CreatePaymentQueryHandler(DataContext context, IAccountService accountService,
            IPaymentsAccessor paymentsAccessor)
        {
            _context = context;
            _accountService = accountService;
            _paymentsAccessor = paymentsAccessor;
        }

        public async Task<ApiResult<string>> Handle(CreatePaymentQuery request, CancellationToken cancellationToken)
        {
            //Only Clients can create payments
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Vendor) return ApiResult<string>.Forbidden();

            //check owner of order
            var order = await _context.Orders.Include(x => x.OrderItems)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (order == null) return ApiResult<string>.Success(null);
            if (order.ClientId != account.Id) return ApiResult<string>.Forbidden();

            var value = 0;
            foreach (var orderItem in order.OrderItems)
            {
                value += orderItem.Value * orderItem.Amount;
            }

            return ApiResult<string>.Success(await _paymentsAccessor.Pay(value));
        }
    }
}