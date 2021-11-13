using System;
using Application.Core;
using MediatR;

namespace Application.Orders
{
    public record CancelOrderCommand(Guid Id) : IRequest<ApiResult<OrderDto>>;
}