using System;
using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ContactsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<Contact>> GetActivity(Guid id)
        {
            return await Mediator.Send(new GetContact.Query(id));
        }
    }
}