using AutoMapper;

namespace SearchAndRescue.Configuration.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Sector, Models.Sector>();
            CreateMap<Models.Sector, Dtos.Get.Sector>();
        }
    }
}
