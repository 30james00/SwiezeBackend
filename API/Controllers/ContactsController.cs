using System;
using System.Threading.Tasks;
using Application.Contacts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ContactsController : BaseApiController
    {
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Contact>> DetailContact(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailContact.Query(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            return HandleResult(await Mediator.Send(new CreateContact.Command(contact)));
        }

        [HttpPatch("{id:guid}")]
        public async Task<IActionResult> EditContact(Guid id, Contact contact)
        {
            return HandleResult(await Mediator.Send(new EditContact.Command(id, contact)));
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteContact(Guid id)
        {
            return HandleResult(await Mediator.Send(new DeleteContact.Command(id)));
        }
    }
}