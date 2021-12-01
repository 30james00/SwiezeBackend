using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using MediatR;
using Persistence;

namespace Application.Photos
{
    public record DeletePhotoCommand(string Id) : IRequest<ApiResult<Unit>>;

    public class DeletePhotoCommandHandler : IRequestHandler<DeletePhotoCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IPhotoAccessor _photoAccessor;

        public DeletePhotoCommandHandler(DataContext context, IPhotoAccessor photoAccessor)
        {
            _context = context;
            _photoAccessor = photoAccessor;
        }

        public async Task<ApiResult<Unit>> Handle(DeletePhotoCommand request, CancellationToken cancellationToken)
        {
            var photo = await _context.Photos.FindAsync(request.Id);

            //check if Photo exists
            if (photo == null) return null;

            var success = _photoAccessor.DeletePhoto(request.Id);

            if (success == null) return ApiResult<Unit>.Failure("Failed to delete Photo from storage");

            _context.Photos.Remove(photo);
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result ? ApiResult<Unit>.Success(Unit.Value) : ApiResult<Unit>.Failure("Failed to delete Photo");
        }
    }
}