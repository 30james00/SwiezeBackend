using Application.Contacts;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Contact, Contact>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<Contact, ContactDto>();
        }
    }
}