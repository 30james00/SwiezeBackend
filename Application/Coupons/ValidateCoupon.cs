using Application.Core;
using MediatR;

namespace Application.Coupons
{
    public record ValidateCouponQuery(string Code) : IRequest<ApiResult<CouponDto>>;
}