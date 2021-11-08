using System.Threading.Tasks;
using Application.Carts;
using Application.Carts.AddToCart;
using Application.Categories;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CartsController : BaseApiController
    {
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<CategoryDto>> ListCart()
        {
            return HandleResult(await Mediator.Send(new ListCartQuery()));
        }

        [Authorize]
        [HttpPost("add")]
        public async Task<IActionResult> AddToCart(AddToCartCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }
    }
}