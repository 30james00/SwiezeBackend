using System.Data;
using Domain;
using FluentValidation;

namespace Application.Contacts
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().MaximumLength(128).EmailAddress();
            RuleFor(x => x.Phone).NotEmpty().MaximumLength(13);
            RuleFor(x => x.Voivodeship).NotEmpty().MaximumLength(20);
            RuleFor(x => x.PostalCode).NotEmpty().MaximumLength(6);
            RuleFor(x => x.City).NotEmpty().MaximumLength(40);
            RuleFor(x => x.Street).NotEmpty().MaximumLength(120);
            RuleFor(x => x.HouseNumber).NotEmpty().MaximumLength(6);
            RuleFor(x => x.FlatNumber).MaximumLength(4);
        }
    }
}