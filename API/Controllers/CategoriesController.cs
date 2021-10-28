using System;
using System.Threading.Tasks;
using Application.Categories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class CategoriesController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<CategoryDto>> DetailCategory(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailCategoryQuery(id)));
        }
    }
}