using System;
using System.Collections.Generic;
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
        public async Task<ActionResult<UnitTypeDto>> DetailUnitType(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailUnitTypeQuery(id)));
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<UnitTypeDto>>> ListUnitType()
        {
            return HandleResult(await Mediator.Send(new ListUnitTypeQuery()));
        }
    }
}