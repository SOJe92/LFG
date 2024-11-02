using AutoMapper;

namespace SearchAndRescue.Products.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Products, Models.Products>();
            CreateMap<Models.Products, Dtos.Get.Products>();
        }
    }
}
