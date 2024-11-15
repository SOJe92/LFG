using AutoMapper;

namespace SearchAndRescue.Configuration.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Permission, Models.Permission>();
            CreateMap<Models.Permission, Dtos.Get.Permission>();
        }
    }
}
