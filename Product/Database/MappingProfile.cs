using AutoMapper;

namespace SearchAndRescue.Product.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Post.Product, Models.Product>();
            CreateMap<Models.Product, Dtos.Post.Product>();
            CreateMap<Dtos.Get.Product, Models.Product>();
            CreateMap<Models.Product, Dtos.Get.Product>();
            CreateMap<Dtos.Put.Product, Models.Product>();
            CreateMap<Models.Product, Dtos.Put.Product>();
        }
    }
}
