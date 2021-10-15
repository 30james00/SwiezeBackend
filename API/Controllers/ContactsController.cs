using System;
using System.Threading.Tasks;
using Application.Contacts;
using Application.Contacts.CreateContact;
using Application.Contacts.EditContact;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ContactsController : BaseApiController
    {
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> DetailContact(Guid id)
        {
            return HandleResult(await Mediator.Send(new DetailContact.Query(id)));
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContact.Command contact)
        {
            return HandleResult(await Mediator.Send(contact));
        }

        [HttpPatch]
        public async Task<IActionResult> EditContact(EditContact.Command contact)
        {
            return HandleResult(await Mediator.Send(contact));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContact()
        {
            return HandleResult(await Mediator.Send(new DeleteContact.Command()));
        }
    }
}