using System;
using Application.Core;
using MediatR;

namespace Application.Reviews.EditReview
{
    public class EditReviewCommand : IRequest<ApiResult<ReviewDto>>
    {
        public Guid Id { get; set; }
        public int NumberOfStars { get; set; }
        public string Description { get; set; }
    }
}