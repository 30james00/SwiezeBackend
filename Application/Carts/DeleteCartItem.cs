using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Carts
{
    public record DeleteCartItemCommand(Guid ProductId) : IRequest<ApiResult<Unit>>;

    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public DeleteCartItemCommandHandler(DataContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<ApiResult<Unit>> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            if (account.AccountType == AccountType.Vendor) return ApiResult<Unit>.Failure("User in not a Client");

            //check if Product is in Cart
            var cartItem = await _context.Carts.Where(x => x.ClientId == account.Id)
                .Where(x => x.ProductId == request.ProductId).FirstOrDefaultAsync(cancellationToken);
            if (cartItem == null) return null;

            _context.Remove(cartItem);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to edit Product in Cart");
        }
    }
}