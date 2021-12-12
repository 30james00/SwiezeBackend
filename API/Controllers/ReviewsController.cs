using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Reviews;
using Application.Reviews.CreateReview;
using Application.Reviews.EditReview;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ReviewsController : BaseApiController
    {
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<PagedList<ReviewDto>>> ListReviews([FromQuery] ReviewParams reviewParams,
            [FromQuery] SortingParams sortingParams)
        {
            return HandlePagedResult(await Mediator.Send(new ListReviewQuery(reviewParams, sortingParams)));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ReviewDto>> CreateReview(CreateReviewCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpPatch]
        public async Task<ActionResult<ReviewDto>> EditReview(EditReviewCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> DeleteReview(Guid id)
        {
            return HandleResult(await Mediator.Send(new DeleteReviewCommand(id)));
        }
    }
}