using System;
using Application.Core;
using MediatR;

namespace Application.Reviews
{
    public record DeleteReviewCommand(Guid Id) : IRequest<ApiResult<Unit>>;
}