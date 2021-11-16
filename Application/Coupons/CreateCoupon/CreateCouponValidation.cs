using Application.Core;
using FluentValidation;

namespace Application.Coupons.CreateCoupon
{
    public class AddCouponValidation : AbstractValidator<CreateCouponCommand>
    {
        public AddCouponValidation()
        {
            RuleFor(x => x.Amount).NotEmpty().GreaterThan(0).LessThan(100);
            RuleFor(x => x.Description).MaximumLength(255);
            RuleFor(x => x.ExpirationDate).FutureDate();
        }
    }
}