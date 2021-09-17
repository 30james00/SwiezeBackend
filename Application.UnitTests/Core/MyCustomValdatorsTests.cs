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
    }

    internal class TestEntityValidator : AbstractValidator<TestEntity>
    {
        public TestEntityValidator()
        {
            RuleFor(x => x.PostalCode).PostalCode();
        }
    }

    [TestFixture]
    public class MyCustomValdatorsTests
    {
        private TestEntityValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new TestEntityValidator();
        }

        [Test]
        public void PostalCode_Valid()
        {
            var entity = new TestEntity
            {
                PostalCode = "20-600"
            };

            var result = _validator.TestValidate(entity);

            result.ShouldNotHaveValidationErrorFor(x => x.PostalCode);
        }

        [Test]
        public void PostalCode_Invalid()
        {
            var entity = new TestEntity
            {
                PostalCode = "02000"
            };

            var result = _validator.TestValidate(entity);

            result.ShouldHaveValidationErrorFor(x => x.PostalCode)
                .WithErrorMessage("Invalid postal code");
        }
    }
}