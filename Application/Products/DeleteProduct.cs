using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Products
{
    public record DeleteProductCommand(Guid Id) : IRequest<ApiResult<Unit>>;

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IUserAccessor _userAccessor;
        private readonly IPhotoAccessor _photoAccessor;

        public DeleteProductCommandHandler(DataContext context, IUserAccessor userAccessor,
            IPhotoAccessor photoAccessor)
        {
            _context = context;
            _userAccessor = userAccessor;
            _photoAccessor = photoAccessor;
        }

        public async Task<ApiResult<Unit>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.Include(x => x.Photos)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (product == null) return ApiResult<Unit>.Failure("Chosen Product doesn't exist");

            //get and check VendorId
            var userId = _userAccessor.GetUserId();
            if (userId == null) return ApiResult<Unit>.Failure("Failed to edit new Product - user not found");
            var vendorId = await _context.Vendors.Where(x => x.AccountId == userId).Select(x => x.Id)
                .FirstOrDefaultAsync(cancellationToken);
            if (vendorId == Guid.Empty)
                return ApiResult<Unit>.Failure("Failed to edit new Product - user is not Vendor");

            if (product.VendorId != vendorId) return ApiResult<Unit>.Forbidden();

            foreach (var photo in product.Photos)
            {
                var success = await _photoAccessor.DeletePhoto(photo.Id);
                if (success == null) return ApiResult<Unit>.Failure("Failed to delete Photo from storage");
                _context.Photos.Remove(photo);
            }

            _context.Products.Remove(product);
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to edit Product");
        }
    }
}