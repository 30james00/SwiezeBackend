using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;

namespace Application.Reviews
{
    public record ListReviewQuery
        (ReviewParams ReviewParams, SortingParams SortingParams) : IRequest<ApiResult<PagedList<ReviewDto>>>;

    public class ListReviewQueryHandler : IRequestHandler<ListReviewQuery, ApiResult<PagedList<ReviewDto>>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public ListReviewQueryHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<PagedList<ReviewDto>>> Handle(ListReviewQuery request,
            CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            var query = _context.Reviews.ProjectTo<ReviewDto>(_mapper.ConfigurationProvider).AsQueryable();

            //handle AccountType
            switch (account.AccountType)
            {
                case AccountType.Client:
                    query = query.Where(x => x.ClientId == account.Id);
                    break;
                case AccountType.Vendor:
                    query = query.Where(x => x.VendorId == account.Id);
                    break;
            }

            //Filter NumberOfStars
            if (request.ReviewParams.NumberOfStars != null)
                query = query.Where(x => x.NumberOfStars == request.ReviewParams.NumberOfStars);

            //Sort
            query = request.SortingParams.GetData(query, "CreationTime");

            return ApiResult<PagedList<ReviewDto>>.Success(await PagedList<ReviewDto>.CreateAsync(query,
                request.ReviewParams.PageNumber, request.ReviewParams.PageSize));
        }
    }
}