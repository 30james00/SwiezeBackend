using System;
using System.Data;
using Application.Core;
using FluentValidation;
using FluentValidation.TestHelper;
using NUnit.Framework;

namespace Application.UnitTests.Core
{
    internal class TestEntity
    {
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
    }

    internal class TestEntityValidator : AbstractValidator<TestEntity>
    {
        public TestEntityValidator()
        {
            RuleFor(x => x.PostalCode).PostalCode();
            RuleFor(x => x.Phone).PhoneNumber();
            RuleFor(x => x.HouseNumber).HouseNumber();
            RuleFor(x => x.FlatNumber).FlatNumber();
        }
    }

    [TestFixture]
    public class MyCustomValidatorsTests
    {
        private TestEntityValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new TestEntityValidator();
        }

        [TestCase("00-000")]
        [TestCase("20-100")]
        [TestCase("99-999")]
        public void PostalCode_Valid(string postalCode)
        {
            var entity = new TestEntity
            {
                PostalCode = postalCode
            };

            var result = _validator.TestValidate(entity);

            result.ShouldNotHaveValidationErrorFor(x => x.PostalCode);
        }

        [TestCase("00000")]
        [TestCase("200-100")]
        [TestCase("2-100")]
        [TestCase("99-99")]
        [TestCase("99-9999")]
        public void PostalCode_Invalid(string postalCode)
        {
            var entity = new TestEntity
            {
                PostalCode = postalCode
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.PostalCode)
                .WithErrorMessage("Invalid postal code");
        }

        [TestCase("+48555111333")]
        [TestCase("+48123456789")]
        [TestCase("+48000000000")]
        public void Phone_Valid(string phoneNumber)
        {
            var entity = new TestEntity
            {
                Phone = phoneNumber
            };

            var result = _validator.TestValidate(entity);

            result.ShouldNotHaveValidationErrorFor(x => x.Phone);
        }

        [TestCase("+485551113334")]
        [TestCase("4812345678")]
        [TestCase("0048123456789")]
        [TestCase("+4800000000")]
        public void Phone_Invalid(string phoneNumber)
        {
            var entity = new TestEntity
            {
                Phone = phoneNumber
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.Phone)
                .WithErrorMessage("Invalid phone number");
        }

        [TestCase("12")]
        [TestCase("1")]
        [TestCase("13A")]
        [TestCase("1254")]
        [TestCase("1245A")]
        public void HouseNumber_Valid(string houseNumber)
        {
            var entity = new TestEntity
            {
                HouseNumber = houseNumber
            };

            var result = _validator.TestValidate(entity);

            result.ShouldNotHaveValidationErrorFor(x => x.HouseNumber);
        }

        [TestCase("?")]
        [TestCase("1B225")]
        [TestCase("A")]
        [TestCase("12+")]
        [TestCase("A2")]
        public void HouseNumber_Invalid(string houseNumber)
        {
            var entity = new TestEntity
            {
                HouseNumber = houseNumber
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.HouseNumber)
                .WithErrorMessage("Invalid house number");
        }

        [Test]
        public void HouseNumber_TooLong()
        {
            var entity = new TestEntity
            {
                HouseNumber = "4512344AX"
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.HouseNumber)
                .WithErrorMessage("House number too long");
        }

        [TestCase("")]
        [TestCase("12")]
        [TestCase("1")]
        [TestCase("13A")]
        [TestCase("1254")]
        [TestCase("12A")]
        [Theory]
        public void FlatNumber_Valid(string flatNumber)
        {
            var entity = new TestEntity
            {
                FlatNumber = flatNumber
            };

            var result = _validator.TestValidate(entity);

            result.ShouldNotHaveValidationErrorFor(x => x.FlatNumber);
        }

        [TestCase("?")]
        [TestCase("1B5")]
        [TestCase("A")]
        [TestCase("12+")]
        [TestCase("A2")]
        public void FlatNumber_Invalid(string flatNumber)
        {
            var entity = new TestEntity
            {
                FlatNumber = flatNumber
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.FlatNumber)
                .WithErrorMessage("Invalid flat number");
        }

        [Test]
        public void FlatNumber_TooLong()
        {
            var entity = new TestEntity
            {
                FlatNumber = "4514AX"
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.FlatNumber)
                .WithErrorMessage("Flat number too long");
        }
    }
}