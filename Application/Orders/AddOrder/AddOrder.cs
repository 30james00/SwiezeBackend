using Application.Core;
using MediatR;

namespace Application.Orders.AddOrder
{
    public class AddOrderCommand : IRequest<ApiResult<OrderDto>>
    {
        
    }
}