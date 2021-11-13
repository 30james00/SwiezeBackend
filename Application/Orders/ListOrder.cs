using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Persistence;

namespace Application.Orders
{
    public record ListOrderQuery
        (OrderParams OrderParams, SortingParams SortingParams) : IRequest<ApiResult<PagedList<OrderDto>>>;

    public class ListOrderQueryHandler : IRequestHandler<ListOrderQuery, ApiResult<PagedList<OrderDto>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;

        public ListOrderQueryHandler(DataContext context, IMapper mapper, IAccountService accountService)
        {
            _context = context;
            _mapper = mapper;
            _accountService = accountService;
        }

        public async Task<ApiResult<PagedList<OrderDto>>> Handle(ListOrderQuery request,
            CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            var query = _context.Orders.ProjectTo<OrderDto>(_mapper.ConfigurationProvider).AsQueryable();

            //get orders of logged in client or vendor
            query = account.AccountType == AccountType.Client
                ? query.Where(x => x.ClientId == account.Id)
                : query.Where(x => x.VendorId == account.Id);

            //Order filter
            if (request.OrderParams.MinOrderDate != null)
                query = query.Where(x =>
                    x.OrderDate >= request.OrderParams.MinOrderDate);
            if (request.OrderParams.MaxOrderDate != null)
                query = query.Where(x =>
                    x.OrderDate <= request.OrderParams.MaxOrderDate);

            //Fulfillment filter
            if (request.OrderParams.MinFulfillmentDate != null)
                query = query.Where(x =>
                    x.FulfillmentDate >= request.OrderParams.MinFulfillmentDate);
            if (request.OrderParams.MaxFulfillmentDate != null)
                query = query.Where(x =>
                    x.FulfillmentDate <= request.OrderParams.MaxFulfillmentDate);

            //IsCanceled filter
            if (request.OrderParams.IsCanceled != null)
                query = query.Where(x => x.IsCanceled == request.OrderParams.IsCanceled);

            //Sort
            query = request.SortingParams.GetData(query, "OrderDate");

            return ApiResult<PagedList<OrderDto>>.Success(await PagedList<OrderDto>.CreateAsync(query,
                request.OrderParams.PageNumber, request.OrderParams.PageSize));
        }
    }
}