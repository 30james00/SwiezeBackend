using System;
using System.Threading.Tasks;
using Application.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ListProducts()
        {
            return HandleResult(await Mediator.Send(new ListProductQuery()));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> DetailProduct(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailProductQuery(id)));
        }
    }
}