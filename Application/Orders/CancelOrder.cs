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
    public record CancelOrderCommand(Guid Id) : IRequest<ApiResult<OrderDto>>;
    
    public class CancelOrderCommandHandler : IRequestHandler<CancelOrderCommand, ApiResult<OrderDto>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CancelOrderCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }
        
        public async Task<ApiResult<OrderDto>> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
        {
            var account = await _accountService.GetAccountInfo();

            var order = await _context.Orders.FindAsync(request.Id);

            //check if order exists
            if (order == null) return ApiResult<OrderDto>.Failure("Order does not exist");

            //check owner of order
            if(account.AccountType == AccountType.Client || account.Id == order.Id)
                return ApiResult<OrderDto>.Forbidden();
            
            //make changes to order
            order.IsCanceled = true;
            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<OrderDto>.Success(_mapper.Map<OrderDto>(order))
                : ApiResult<OrderDto>.Failure("Failed to cancel Order");
        }
    }
}