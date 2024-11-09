using AutoMapper;

namespace SearchAndRescue.Role.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Role, Models.Role>();
            CreateMap<Models.Role, Dtos.Get.Role>();
        }
    }
}
