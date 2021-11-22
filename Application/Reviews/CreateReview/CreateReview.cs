using System;
using Application.Core;
using Domain;
using MediatR;

namespace Application.Reviews.CreateReview
{
    public class CreateReviewCommand : IRequest<ApiResult<ReviewDto>>
    {
        public int NumberOfStars { get; set; }
        public string Description { get; set; }
        public Guid OrderId { get; set; }
    }
}