using System.Threading.Tasks;
using Application.Carts;
using Application.Categories;
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
    }
}