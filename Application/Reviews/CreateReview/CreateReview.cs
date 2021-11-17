using Application.Core;
using MediatR;

namespace Application.Reviews.CreateReview
{
    public class CreateReviewCommand : IRequest<ApiResult<ReviewDto>>
    {
        
    }
}