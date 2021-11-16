using Domain;

namespace Application.Services
{
    public interface ICouponService
    {
        public bool IsValid(Coupon coupon);
        public string GenerateCode();
    }
}