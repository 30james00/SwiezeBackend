using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Core;
using Application.Services;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Coupons
{
    public record ValidateCouponQuery(string Code) : IRequest<ApiResult<CouponDto>>;

    public class ValidateCouponQueryHandle : IRequestHandler<ValidateCouponQuery, ApiResult<CouponDto>>
    {
        private readonly DataContext _context;
        private readonly ICouponService _couponService;
        private readonly IMapper _mapper;

        public ValidateCouponQueryHandle(DataContext context, ICouponService couponService, IMapper mapper)
        {
            _context = context;
            _couponService = couponService;
            _mapper = mapper;
        }

        public async Task<ApiResult<CouponDto>> Handle(ValidateCouponQuery request, CancellationToken cancellationToken)
        {
            //get existing Coupon
            var coupon = await _context.Coupons.Where(x => x.Code == request.Code)
                .FirstOrDefaultAsync(cancellationToken);
            if (coupon == null) return null;

            return !_couponService.IsValid(coupon)
                ? null
                : ApiResult<CouponDto>.Success(_mapper.Map<CouponDto>(coupon));
        }
    }
}