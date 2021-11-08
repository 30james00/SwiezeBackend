using FluentValidation;

namespace Application.Carts.AddToCart
{
    public class AddToCartValidator : AbstractValidator<AddToCartCommand>
    {
        public AddToCartValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty();
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}