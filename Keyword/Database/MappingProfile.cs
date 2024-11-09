using AutoMapper;

namespace SearchAndRescue.Keyword.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Dtos.Get.Keyword>();
        }
    }
}
