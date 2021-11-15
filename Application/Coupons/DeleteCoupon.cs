using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Coupons
{
    public record DeleteCouponCommand(Guid Id) : IRequest<ApiResult<Unit>>;
    
    public class DeleteCouponCommandHandler : IRequestHandler<DeleteCouponCommand, ApiResult<Unit>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public DeleteCouponCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }
        
        public async Task<ApiResult<Unit>> Handle(DeleteCouponCommand request, CancellationToken cancellationToken)
        {
            //check if Account is owner of coupon
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Client) return ApiResult<Unit>.Forbidden();
            
            //get existing Coupon
            var coupon = await _context.Coupons.FindAsync(request.Id);
            if(coupon == null) return null;
            if(coupon.VendorId != account.Id) return ApiResult<Unit>.Forbidden();

            _context.Coupons.Remove(coupon);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<Unit>.Success(Unit.Value)
                : ApiResult<Unit>.Failure("Failed to delete Coupon");
        }
    }
}