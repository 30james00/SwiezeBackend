using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Reviews.CreateReview
{
    public class CreateReviewCommand : IRequest<ApiResult<ReviewDto>>
    {
        public int NumberOfStars { get; set; }
        public string Description { get; set; }
        public Guid OrderId { get; set; }
    }

    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand, ApiResult<ReviewDto>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CreateReviewCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<ReviewDto>> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            //check Order
            var order = await _context.Orders.FirstOrDefaultAsync(cancellationToken);
            if (order == null) return null;
            if(order.FulfillmentDate == null) return ApiResult<ReviewDto>.Failure("Order is not fulfilled yet");

            //check owner
            if (account.AccountType == AccountType.Vendor || account.Id != order.ClientId)
                return ApiResult<ReviewDto>.Forbidden();

            var review = new Review
            {
                CreationTime = DateTime.Now,
                NumberOfStars = request.NumberOfStars,
                Description = request.Description,
                OrderId = request.OrderId,
            };

            await _context.AddAsync(review, cancellationToken);
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<ReviewDto>.Success(_mapper.Map<ReviewDto>(review))
                : ApiResult<ReviewDto>.Failure("Failed to create Review");
        }
    }
}