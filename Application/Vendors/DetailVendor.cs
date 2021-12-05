using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Vendor
{
    public record DetailVendorQuery(Guid Id) : IRequest<ApiResult<VendorDto>>;

    public class DetailVendorQueryHandler : IRequestHandler<DetailVendorQuery, ApiResult<VendorDto>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DetailVendorQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<VendorDto>> Handle(DetailVendorQuery request, CancellationToken cancellationToken)
        {
            return ApiResult<VendorDto>.Success(await _context.Vendors
                .ProjectTo<VendorDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken));
        }
    }
}