using FluentValidation;

namespace Application.Reviews.EditReview
{
    public class EditReviewValidator : AbstractValidator<EditReviewCommand>
    {
        public EditReviewValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.NumberOfStars).NotEmpty().GreaterThanOrEqualTo(1).LessThanOrEqualTo(5);
            RuleFor(x => x.Description).MaximumLength(800);
        }
    }
}