using AutoMapper;

namespace SearchAndRescue.Entities.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Entities, Models.Entities>();
            CreateMap<Models.Entities, Dtos.Get.Entities>();
        }
    }
}
