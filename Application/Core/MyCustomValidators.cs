using System;
using Bogus.Extensions;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Application.Core
{
    public static class MyCustomValidators
    {
        public static IRuleBuilderOptions<T, string> PostalCode<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Matches("^[0-9]{2}-[0-9]{3}$").WithMessage("Invalid postal code");
        }

        public static IRuleBuilderOptions<T, string> PhoneNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            //consider more rules to match other countries
            return ruleBuilder.Matches("^\\+48(\\d){9}$").WithMessage("Invalid phone number");
        }

        public static IRuleBuilderOptions<T, string> HouseNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Matches("^[0-9]{1,6}([A-Z]{1,5})?$").WithMessage("Invalid house number")
                .MaximumLength(6).WithMessage("House number too long");
        }

        public static IRuleBuilderOptions<T, string> FlatNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Matches("^([0-9]{1,4}([A-Z]{1,4})?)?$").WithMessage("Invalid flat number")
                .MaximumLength(4).WithMessage("Flat number too long");
        }

        public static IRuleBuilderOptions<T, DateTime?> FutureDate<T>(this IRuleBuilder<T, DateTime?> ruleBuilder)
        {
            return ruleBuilder.Must(x => x == null || x > DateTime.Now).WithMessage("Date must be in future");
        }
    }
}