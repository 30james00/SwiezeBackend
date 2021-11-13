using System;
using Application.Core;
using MediatR;

namespace Application.Orders
{
    public record FulfillOrderCommand(Guid Id) : IRequest<ApiResult<OrderDto>>;
}