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

namespace Application.Coupons.CreateCoupon
{
    public class CreateCouponCommand : IRequest<ApiResult<CouponDto>>
    {
        public string Code { get; set; }
        public int Amount { get; set; }
#nullable enable
        public string? Description { get; set; }
#nullable disable
        public int? AmountOfUses { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }

    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommand, ApiResult<CouponDto>>
    {
        private readonly DataContext _context;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CreateCouponCommandHandler(DataContext context, IAccountService accountService, IMapper mapper)
        {
            _context = context;
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<ApiResult<CouponDto>> Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            //check if Account is Vendor
            var account = await _accountService.GetAccountInfo();
            if (account.AccountType == AccountType.Client) return ApiResult<CouponDto>.Forbidden();

            //check if Coupon already exists
            if (_context.Coupons.Where(x => x.VendorId == account.Id)
                .Any(x => x.Code == request.Code))
                return ApiResult<CouponDto>.Failure("Coupon with this code already exists");

            var coupon = new Coupon
            {
                Code = request.Code,
                Amount = request.Amount,
                Description = request.Description,
                AmountOfUses = request.AmountOfUses,
                ExpirationDate = request.ExpirationDate,
                VendorId = account.Id,
            };

            await _context.Coupons.AddAsync(coupon, cancellationToken);

            var result = await _context.SaveChangesAsync(cancellationToken) > 0;

            return result
                ? ApiResult<CouponDto>.Success(_mapper.Map<CouponDto>(coupon))
                : ApiResult<CouponDto>.Failure("Failed to create Coupon");
        }
    }
}