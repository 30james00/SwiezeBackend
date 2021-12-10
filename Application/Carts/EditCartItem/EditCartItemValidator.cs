using FluentValidation;

namespace Application.Carts.EditCartItem
{
    public class EditCartItemValidator : AbstractValidator<EditCartItemCommand>
    {
        public EditCartItemValidator()
        {
            RuleFor(x => x.ProductId).NotNull();
            RuleFor(x => x.Amount).NotEmpty().GreaterThanOrEqualTo(1);
        }
    }
}