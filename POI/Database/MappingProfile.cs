using AutoMapper;

namespace SearchAndRescue.POI.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, Dtos.Get.PointOfInterest>();
        }
    }
}
