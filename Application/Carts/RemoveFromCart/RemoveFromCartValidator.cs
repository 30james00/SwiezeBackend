using FluentValidation;

namespace Application.Carts.RemoveFromCart
{
    public class RemoveFromCartValidator : AbstractValidator<RemoveFromCartCommand>
    {
        public RemoveFromCartValidator()
        {
            RuleFor(x => x.ProductId).NotNull();
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}