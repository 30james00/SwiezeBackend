using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;

namespace Application.Vendor
{
    public record ListVendorQuery(PagingParams PagingParams) : IRequest<ApiResult<PagedList<VendorDto>>>;

    public class ListVendorQueryHandler : IRequestHandler<ListVendorQuery, ApiResult<PagedList<VendorDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ListVendorQueryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResult<PagedList<VendorDto>>> Handle(ListVendorQuery request,
            CancellationToken cancellationToken)
        {
            var query = _context.Vendors.ProjectTo<VendorDto>(_mapper.ConfigurationProvider).AsQueryable();

            return ApiResult<PagedList<VendorDto>>.Success(await PagedList<VendorDto>.CreateAsync(query,
                request.PagingParams.PageNumber, request.PagingParams.PageSize));
        }
    }
}