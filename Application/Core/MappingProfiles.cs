using System.Linq;
using Application.Carts;
using Application.Categories;
using Application.Contacts;
using Application.Contacts.CreateContact;
using Application.Contacts.EditContact;
using Application.Products;
using Application.UnitTypes;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Cart
            CreateMap<Cart, CartDto>();

            //Category
            CreateMap<Category, CategoryDto>();

            //Contact
            CreateMap<Contact, ContactDto>();
            CreateMap<CreateContactCommand, Contact>();
            CreateMap<EditContactCommand, Contact>();

            //Product
            CreateMap<Product, ProductDto>().ForMember(
                x => x.Categories,
                o => o.MapFrom(
                    x => x.ProductCategories.Select(p => p.CategoryId).ToList()
                )
            );

            //UnitType
            CreateMap<UnitType, UnitTypeDto>();
        }
    }
}