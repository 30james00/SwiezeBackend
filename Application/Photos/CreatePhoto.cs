using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Interfaces;
using Application.Services;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Photos
{
    public class CreatePhotoCommand : IRequest<ApiResult<PhotoDto>>
    {
        public IFormFile File { get; set; }
    }

    public class CreatePhotoCommandHandler : IRequestHandler<CreatePhotoCommand, ApiResult<PhotoDto>>
    {
        private readonly DataContext _context;
        private readonly IPhotoAccessor _photoAccessor;
        private readonly IMapper _mapper;

        public CreatePhotoCommandHandler(DataContext context, IPhotoAccessor photoAccessor,
            IMapper mapper)
        {
            _context = context;
            _photoAccessor = photoAccessor;
            _mapper = mapper;
        }

        public async Task<ApiResult<PhotoDto>> Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {
            var photoUploadResult = await _photoAccessor.AddPhoto(request.File);

            var photo = new Photo
            {
                Url = photoUploadResult.Url,
                Id = photoUploadResult.PublicId
            };

            await _context.Photos.AddAsync(photo, cancellationToken);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<PhotoDto>.Success(_mapper.Map<PhotoDto>(photo))
                : ApiResult<PhotoDto>.Failure("Failed to add Photo");
        }
    }
}