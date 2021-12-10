using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Carts.CreateCartItem
{
    public record CreateCartItemCommand(Guid ProductId, int Amount) : IRequest<ApiResult<Unit>>;

    public class CreateCartItemCommandHandler : IRequestHandler<CreateCartItemCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public CreateCartItemCommandHandler(DataContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<ApiResult<Unit>> Handle(CreateCartItemCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            if (account.AccountType == AccountType.Vendor) return ApiResult<Unit>.Failure("User in not a Client");

            // check Product availability
            var product = await _context.Products.Where(x => x.Id == request.ProductId).Select(x => x.Stock)
                .FirstOrDefaultAsync(cancellationToken);
            if (product < request.Amount) return ApiResult<Unit>.Failure("Not enough units in stock");

            var cartItem = await _context.Carts.Where(x => x.ClientId == account.Id)
                .Where(x => x.ProductId == request.ProductId)
                .FirstOrDefaultAsync(cancellationToken);

            // Product was already in Cart
            if (cartItem != null)
                return ApiResult<Unit>.Failure("Product already in Cart");

            await _context.Carts.AddAsync(new Cart
            {
                Amount = request.Amount,
                ClientId = account.Id,
                ProductId = request.ProductId
            }, cancellationToken);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to add Product to Cart");
        }
    }
}