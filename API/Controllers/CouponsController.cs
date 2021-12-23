using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Coupons;
using Application.Coupons.CreateCoupon;
using Application.Coupons.EditCoupon;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CouponsController : BaseApiController
    {
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<CouponDto>>> ListCoupons()
        {
            return HandleResult(await Mediator.Send(new ListCouponQuery()));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<CouponDto>> AddCoupon(CreateCouponCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpPatch]
        public async Task<ActionResult<CouponDto>> EditCoupon(EditCouponCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Unit>> DeleteCoupon(Guid id)
        {
            return HandleResult(await Mediator.Send(new DeleteCouponCommand(id)));
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<CouponDto>> ValidateCoupon(string id)
        {
            return HandleResult(await Mediator.Send(new ValidateCouponQuery(id)));
        }
    }
}