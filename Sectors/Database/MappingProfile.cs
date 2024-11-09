using AutoMapper;

namespace SearchAndRescue.Sectors.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Sector, Models.Sector>();
            CreateMap<Models.Sector, Dtos.Get.Sector>();
            CreateMap<Dtos.Get.Service, Models.Service>();
            CreateMap<Models.Service, Dtos.Get.Service>();
            CreateMap<Dtos.Get.SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, Dtos.Get.SectorService>();
        }
    }
}
