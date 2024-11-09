using AutoMapper;

namespace SearchAndRescue.Entity.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Post.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Post.Entity>();
            CreateMap<Dtos.Get.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Get.Entity>();
            CreateMap<Dtos.Put.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Put.Entity>();
            CreateMap<Dtos.Get.EntityType, Models.EntityType>();
            CreateMap<Models.EntityType, Dtos.Get.EntityType>();
        }
    }
}
