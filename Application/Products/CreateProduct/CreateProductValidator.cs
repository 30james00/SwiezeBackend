using FluentValidation;

namespace Application.Products.CreateProduct
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(30);
            RuleFor(x => x.Value).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.Unit).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.Stock).NotEmpty().GreaterThanOrEqualTo(1);
            RuleFor(x => x.UnitTypeId).NotEmpty();
            RuleForEach(x => x.Categories).NotEmpty();
        }
    }
}