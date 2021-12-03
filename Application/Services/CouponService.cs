using System;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Persistence;

namespace Application.Services
{
    public class CouponService : ICouponService
    {
        private readonly DataContext _context;

        public CouponService(DataContext context)
        {
            _context = context;
        }

        public bool IsValid(Coupon coupon)
        {
            if (coupon.ExpirationDate != null && coupon.ExpirationDate < DateTime.Now)
                return false;
            if (coupon.AmountOfUses is <= 0)
                return false;
            return true;
        }

        public string GenerateCode()
        {
            var code = RandomString(8);

            while (_context.Coupons.Any(x => x.Code == code))
                code = RandomString(8);

            return code;
        }

        private static readonly Random Random = new Random();

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}