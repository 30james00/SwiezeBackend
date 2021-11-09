using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Carts.RemoveFromCart
{
    public record RemoveFromCartCommand(Guid ProductId, int Amount) : IRequest<ApiResult<Unit>>;

    public class RemoveFromCartCommandHandler : IRequestHandler<RemoveFromCartCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public RemoveFromCartCommandHandler(DataContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<ApiResult<Unit>> Handle(RemoveFromCartCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            if (account.AccountType == AccountType.Vendor) return ApiResult<Unit>.Failure("User in not a Client");

            //check if Product is in Cart
            var cartItem = await _context.Carts.Where(x => x.ClientId == account.Id)
                .Where(x => x.ProductId == request.ProductId).FirstOrDefaultAsync(cancellationToken);

            //check if there are enough products in Cart
            if (cartItem == null || cartItem.Amount < request.Amount)
                return ApiResult<Unit>.Failure("Not enough units in Cart");

            //delete or change amount in Cart
            if (request.Amount == cartItem.Amount)
                _context.Carts.Remove(cartItem);
            else cartItem.Amount -= request.Amount;

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to remove Product from Cart");
        }
    }
}