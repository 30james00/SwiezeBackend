using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using MediatR;
using Persistence;

namespace Application.Orders
{
    public record FulfillOrderCommand(Guid Id) : IRequest<ApiResult<OrderDto>>;

    public class FulfillOrderCommandHandler : IRequestHandler<FulfillOrderCommand, ApiResult<OrderDto>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public FulfillOrderCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<OrderDto>> Handle(FulfillOrderCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            var order = await _context.Orders.FindAsync(request.Id);

            //check if order exists
            if (order == null) return ApiResult<OrderDto>.Failure("Order does not exist");

            //check owner of order
            if (account.AccountType == AccountType.Client || account.Id == order.Id)
                return ApiResult<OrderDto>.Forbidden();

            if (order.FulfillmentDate != null) return ApiResult<OrderDto>.Failure("Order is already fulfilled");

            //make changes to order
            order.FulfillmentDate = DateTime.Now;
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<OrderDto>.Success(_mapper.Map<OrderDto>(order))
                : ApiResult<OrderDto>.Failure("Failed to fulfill Order");
        }
    }
}