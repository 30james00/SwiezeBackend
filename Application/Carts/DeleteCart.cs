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
    public record DeleteCartCommand : IRequest<ApiResult<Unit>>;

    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public DeleteCartCommandHandler(DataContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<ApiResult<Unit>> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Vendor) return ApiResult<Unit>.Failure("User in not a Client");

            //get all Cart Items of Client
            var cartItems = await _context.Carts.Where(x => x.ClientId == account.Id).ToListAsync(cancellationToken);
            //no action if Cart empty
            if (cartItems.Count == 0) return ApiResult<Unit>.Success(Unit.Value);

            _context.Carts.RemoveRange(cartItems);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to delete Cart");
        }
    }
}