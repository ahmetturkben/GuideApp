using AutoMapper;

namespace Guide.Service.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Entities.Person, BL.Person>().ReverseMap();
            CreateMap<Data.Entities.Contact, BL.Contact>().ReverseMap();
        }
    }
}
