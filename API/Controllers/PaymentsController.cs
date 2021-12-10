using System;
using System.Threading.Tasks;
using Application.Payments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace API.Controllers
{
    public class PaymentsController : BaseApiController
    {
        [Authorize]
        [HttpPost("{id:guid}")]
        public async Task<ActionResult<string>> CreatePayment(Guid id)
        {
            return HandleResult(await Mediator.Send(new CreatePaymentQuery(id)));
        }
    }
}