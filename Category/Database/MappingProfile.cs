using AutoMapper;

namespace SearchAndRescue.Category.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Category, Models.Category>();
            CreateMap<Models.Category, Dtos.Get.Category>();
        }
    }
}
