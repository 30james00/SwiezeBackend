using System;
using System.Threading.Tasks;
using Application.Core;
using Application.Vendor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class VendorsController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<PagedList<VendorDto>>> ListVendor([FromQuery] PagingParams pagingParams)
        {
            return HandlePagedResult(await Mediator.Send(new ListVendorQuery(pagingParams)));
        }

        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<VendorDto>> DetailVendor(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailVendorQuery(id)));
        }
    }
}