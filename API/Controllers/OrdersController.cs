using System.Threading.Tasks;
using Application.Core;
using Application.Orders;
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
    }
}