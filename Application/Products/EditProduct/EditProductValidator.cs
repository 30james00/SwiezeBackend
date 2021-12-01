using FluentValidation;

namespace Application.Products.EditProduct
{
    public class EditProductValidator : AbstractValidator<EditProductCommand>
    {
        public EditProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Value).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.Unit).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.Stock).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.UnitTypeId).NotEmpty();
            RuleForEach(x => x.Categories).NotEmpty();
            RuleForEach(x => x.Photos).NotEmpty();
        }
    }
}