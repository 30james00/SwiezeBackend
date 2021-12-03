using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Reviews
{
    public record DeleteReviewCommand(Guid Id) : IRequest<ApiResult<Unit>>;

    public class DeleteReviewCommandHandler : IRequestHandler<DeleteReviewCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;

        public DeleteReviewCommandHandler(DataContext context, IAccountService accountService)
        {
            _context = context;
            _accountService = accountService;
        }

        public async Task<ApiResult<Unit>> Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            //get Review
            var review = await _context.Reviews.Include(x => x.Order)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (review == null) return null;

            //check owner
            if (account.AccountType != AccountType.Client || review.Order.ClientId != account.Id)
                return ApiResult<Unit>.Forbidden();

            _context.Remove(review);
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result ? ApiResult<Unit>.Success(Unit.Value) : ApiResult<Unit>.Failure("Failed to delete Review");
        }
    }
}