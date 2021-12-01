using System.Threading.Tasks;
using Application.Photos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PhotosController : BaseApiController
    {
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreatePhoto([FromForm] CreatePhotoCommand command)
        {
            return HandleResult(await Mediator.Send(command));
        }
    }
}