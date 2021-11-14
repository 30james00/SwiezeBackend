using System;
using Application.Core;
using MediatR;

namespace Application.Coupons
{
    public record DeleteCouponCommand(Guid Id) : IRequest<ApiResult<CouponDto>>;
}