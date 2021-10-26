using System;
using System.Threading.Tasks;
using Application.UnitTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UnitTypesController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> DetailUnitType(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailUnitTypeQuery(id)));
        }
    }
}