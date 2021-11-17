using Application.Core;
using MediatR;

namespace Application.Reviews
{
    public class ListReviewQuery : IRequest<ApiResult<PagedList<ReviewDto>>>
    {
        
    }
}