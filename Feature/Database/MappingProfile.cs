using AutoMapper;

namespace SearchAndRescue.Feature.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Feature, Models.Feature>();
            CreateMap<Models.Feature, Dtos.Get.Feature>();
        }
    }
}
