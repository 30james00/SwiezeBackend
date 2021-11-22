using FluentValidation;

namespace Application.Reviews.CreateReview
{
    public class CreateReviewValidator : AbstractValidator<CreateReviewCommand>
    {
        public CreateReviewValidator()
        {
            RuleFor(x => x.NumberOfStars).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(5);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(800);
            RuleFor(x => x.OrderId).NotEmpty();
        }
    }
}