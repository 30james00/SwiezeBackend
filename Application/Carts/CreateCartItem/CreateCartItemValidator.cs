using Application.Carts.CreateCartItem;
using FluentValidation;

namespace Application.Carts.AddToCart
{
    public class CreateCartItemValidator : AbstractValidator<CreateCartItemCommand>
    {
        public CreateCartItemValidator()
        {
            RuleFor(x => x.ProductId).NotNull();
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}