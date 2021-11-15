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

namespace Application.Coupons.EditCoupon
{
    public class EditCouponCommand : IRequest<ApiResult<CouponDto>>
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable
        public int? AmountOfUses { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
    
    public class EditCouponCommandHandler : IRequestHandler<EditCouponCommand, ApiResult<CouponDto>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public EditCouponCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }
        
        public async Task<ApiResult<CouponDto>> Handle(EditCouponCommand request, CancellationToken cancellationToken)
        {
            //check if Account is owner of coupon
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Client) return ApiResult<CouponDto>.Forbidden();
            
            //get existing Coupon
            var coupon = await _context.Coupons.FindAsync(request.Id);
            if(coupon == null) return null;
            if(coupon.VendorId != account.Id) return ApiResult<CouponDto>.Forbidden();

            _mapper.Map(request, coupon);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<CouponDto>.Success(_mapper.Map<CouponDto>(coupon))
                : ApiResult<CouponDto>.Failure("Failed to edit Coupon");
        }
    }
}