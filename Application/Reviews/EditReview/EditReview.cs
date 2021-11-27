using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Reviews.EditReview
{
    public class EditReviewCommand : IRequest<ApiResult<ReviewDto>>
    {
        public Guid Id { get; set; }
        public int NumberOfStars { get; set; }
        public string Description { get; set; }
    }

    public class EditReviewCommandHandler : IRequestHandler<EditReviewCommand, ApiResult<ReviewDto>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public EditReviewCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<ReviewDto>> Handle(EditReviewCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            //check old Review
            var review = await _context.Reviews.Include(x => x.Order)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (review == null) return null;

            //check owner
            if (account.AccountType != AccountType.Client || review.Order.ClientId != account.Id)
                return ApiResult<ReviewDto>.Forbidden();

            review.Description = request.Description;
            review.CreationTime = DateTime.Now;
            review.NumberOfStars = request.NumberOfStars;

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<ReviewDto>.Success(_mapper.Map<ReviewDto>(review))
                : ApiResult<ReviewDto>.Failure("Failed to edit Review");
        }
    }
}