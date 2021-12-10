using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Carts;
using Application.Carts.AddToCart;
using Application.Carts.CreateCartItem;
using Application.Carts.EditCartItem;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CartsController : BaseApiController
    {
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<CartDto>>> ListCart()
        {
            return HandleResult(await Mediator.Send(new ListCartQuery()));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddToCart(CreateCartItemCommand itemCommand)
        {
            return HandleResult(await Mediator.Send(itemCommand));
        }
        
        [Authorize]
        [HttpPatch]
        public async Task<IActionResult> RemoveFromCart(EditCartItemCommand itemCommand)
        {
            return HandleResult(await Mediator.Send(itemCommand));
        }        
        
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteCart()
        {
            return HandleResult(await Mediator.Send(new DeleteCartCommand()));
        }
        
        [Authorize]
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCartItem(Guid id)
        {
            return HandleResult(await Mediator.Send(new DeleteCartItemCommand(id)));
        }
    }
}