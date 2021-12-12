using System.Linq;
using Application.Carts;
using Application.Categories;
using Application.Clients;
using Application.Contacts;
using Application.Contacts.CreateContact;
using Application.Contacts.EditContact;
using Application.Coupons;
using Application.Coupons.EditCoupon;
using Application.Orders;
using Application.Photos;
using Application.Products;
using Application.Reviews;
using Application.Reviews.EditReview;
using Application.UnitTypes;
using Application.Vendor;
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

            //Client
            CreateMap<Client, ClientDto>().ForMember(
                x => x.ContactId, o => o.MapFrom(x => x.Account.Contact.Id));

            //Contact
            CreateMap<Contact, ContactDto>();
            CreateMap<CreateContactCommand, Contact>();
            CreateMap<EditContactCommand, Contact>();

            //Coupon
            CreateMap<Coupon, CouponDto>();
            CreateMap<EditCouponCommand, Coupon>();

            //Order
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<Order, OrderDto>().ForMember(
                x => x.Items,
                o => o.MapFrom(
                    x => x.OrderItems.ToList()));

            //Photo
            CreateMap<Photo, PhotoDto>();

            //Product
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.Categories,
                    o => o.MapFrom(x => x.ProductCategories.Select(p => p.CategoryId).ToList()))
                .ForMember(x => x.Photos, o => o.MapFrom(x => x.Photos.Select(p => p.Url).ToList()));

            //Review
            CreateMap<Review, ReviewDto>()
                .ForMember(x => x.ClientId, o => o.MapFrom(x => x.Order.ClientId))
                .ForMember(x => x.VendorId, o => o.MapFrom(x => x.Order.VendorId));

            //UnitType
            CreateMap<UnitType, UnitTypeDto>();

            //Vendor
            CreateMap<Domain.Vendor, VendorDto>().ForMember(
                x => x.ContactId, o => o.MapFrom(x => x.Account.Contact.Id));
            ;
        }
    }
}