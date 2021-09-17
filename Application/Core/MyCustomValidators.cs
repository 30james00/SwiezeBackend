using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Application.Core
{
    public static class MyCustomValidators
    {
        public static IRuleBuilderOptions<T, string> PostalCode<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Matches("[0-9]{2}-[0-9]{3}").WithMessage("Invalid postal code");
        }
    }
}