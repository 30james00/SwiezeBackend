using System;
using System.Threading.Tasks;
using Application.Clients;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ClientsController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ClientDto>> DetailClient(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailClientQuery(id)));
        }
    }
}