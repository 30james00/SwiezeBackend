using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Products;
using Application.Products.CreateProduct;
using Application.Products.EditProduct;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<PagedList<ProductDto>>> ListProducts([FromQuery] PagingParams param)
        {
            return HandlePagedResult(await Mediator.Send(new ListProductQuery(param)));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProductDto>> DetailProduct(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailProductQuery(id)));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct(CreateProductCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpPatch]
        public async Task<ActionResult<ProductDto>> EditProduct(EditProductCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }

        [Authorize]
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            return HandleResult(await Mediator.Send(new DeleteProductCommand(id)));
        }
    }
}