using Application.Core;
using MediatR;

namespace Application.Reviews.EditReview
{
    public class EditReviewCommand : IRequest<ApiResult<ReviewDto>>
    {
        
    }
}