using Application.Contacts;
using Application.Contacts.CreateContact;
using Application.Contacts.EditContact;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Contact, ContactDto>();
            CreateMap<CreateContact.Command, Contact>();
            CreateMap<EditContact.Command, Contact>();
        }
    }
}