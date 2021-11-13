using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Orders;
using Application.Orders.AddOrder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrdersController : BaseApiController
    {
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<PagedList<OrderDto>>> ListOrder([FromQuery] OrderParams orderParams, [FromQuery] SortingParams sortingParams)
        {
            return HandlePagedResult(await Mediator.Send(new ListOrderQuery(orderParams, sortingParams)));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<OrderDto>> AddOrder(AddOrderCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpPatch("${id:guid}/fulfill")]
        public async Task<ActionResult<OrderDto>> FulfillOrder(Guid id)
        {
            return HandleResult(await Mediator.Send(new FulfillOrderCommand(id)));
        }

        [Authorize]
        [HttpPatch("${id:guid}/cancel")]
        public async Task<ActionResult<OrderDto>> CancelOrder(Guid id)
        {
            return HandleResult(await Mediator.Send(new CancelOrderCommand(id)));
        }
    }
}