using System;
using System.Threading.Tasks;
using Application.Contacts;
using Application.Contacts.CreateContact;
using Application.Contacts.EditContact;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ContactsController : BaseApiController
    {
        [AllowAnonymous]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ContactDto>> DetailContact(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailContactQuery(id)));
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ContactDto>> CreateContact(CreateContactCommand contact)
        {
            return HandleResult(await Mediator.Send(contact));
        }

        [Authorize]
        [HttpPatch]
        public async Task<IActionResult> EditContact(EditContactCommand contact)
        {
            return HandleResult(await Mediator.Send(contact));
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteContact()
        {
            return HandleResult(await Mediator.Send(new DeleteContactCommand()));
        }
    }
}