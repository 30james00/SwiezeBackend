using Application.Core;
using Application.Coupons.CreateCoupon;
using FluentValidation;

namespace Application.Coupons.EditCoupon
{
    public class EditCouponValidation : AbstractValidator<EditCouponCommand>
    {
        public EditCouponValidation()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Amount).NotEmpty().GreaterThan(0).LessThan(100);
            RuleFor(x => x.Description).MaximumLength(255);
            RuleFor(x => x.ExpirationDate).FutureDate();
        }
    }
}