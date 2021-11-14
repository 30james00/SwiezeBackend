using Application.Core;
using Application.Orders;
using MediatR;

namespace Application.Coupons.AddCoupon
{
    public class AddCouponCommand : IRequest<ApiResult<OrderDto>>
    {
        
    }
}