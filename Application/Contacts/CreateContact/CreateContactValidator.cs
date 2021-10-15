using Application.Core;
using FluentValidation;

namespace Application.Contacts.CreateContact
{
    public class CreateContactValidator : AbstractValidator<CreateContact.Command>
    {
        public CreateContactValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().MaximumLength(128).EmailAddress();
            RuleFor(x => x.Phone).NotEmpty().PhoneNumber();
            RuleFor(x => x.Voivodeship).NotEmpty().MaximumLength(20);
            RuleFor(x => x.PostalCode).NotEmpty().PostalCode();
            RuleFor(x => x.City).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Street).NotEmpty().MaximumLength(120);
            RuleFor(x => x.HouseNumber).NotEmpty().HouseNumber();
            RuleFor(x => x.FlatNumber).FlatNumber();
        }
    }
}