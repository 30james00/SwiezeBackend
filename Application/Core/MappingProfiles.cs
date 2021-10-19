using System.Linq;
using Application.Contacts;
using Application.Contacts.CreateContact;
using Application.Contacts.EditContact;
using Application.Products;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Contact, ContactDto>();
            CreateMap<CreateContactCommand, Contact>();
            CreateMap<EditContactCommand, Contact>();
            CreateMap<Product, ProductDto>().ForMember(
                x => x.Categories,
                o => o.MapFrom(
                    x => x.ProductCategories.Select(p => p.CategoryId).ToList()
                )
            );
            
        }
    }
}