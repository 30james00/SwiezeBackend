using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Carts.EditCartItem
{
    public record EditCartItemCommand(Guid ProductId, int Amount) : IRequest<ApiResult<Unit>>;

    public class EditCartItemCommandHandler : IRequestHandler<EditCartItemCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public EditCartItemCommandHandler(DataContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<ApiResult<Unit>> Handle(EditCartItemCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            if (account.AccountType == AccountType.Vendor) return ApiResult<Unit>.Failure("User in not a Client");

            //check if Product is in Cart
            var cartItem = await _context.Carts.Where(x => x.ClientId == account.Id)
                .Where(x => x.ProductId == request.ProductId).FirstOrDefaultAsync(cancellationToken);

            if (cartItem == null) return null;

            // check Product availability
            var product = await _context.Products.Where(x => x.Id == request.ProductId).Select(x => x.Stock)
                .FirstOrDefaultAsync(cancellationToken);
            if (product < request.Amount) return ApiResult<Unit>.Failure("Not enough units in stock");

            cartItem.Amount = request.Amount;

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to edit Product in Cart");
        }
    }
}