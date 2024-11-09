using AutoMapper;

namespace SearchAndRescue.ContactType.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, Dtos.Get.ContactType>();
        }
    }
}
