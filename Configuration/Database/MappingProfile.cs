using AutoMapper;

namespace SearchAndRescue.Configuration.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.Sector, Models.Sector>();
            CreateMap<Models.Sector, Dtos.Get.Sector>();
            CreateMap<Dtos.Get.Category, Models.Category>();
            CreateMap<Models.Category, Dtos.Get.Category>();
            CreateMap<Dtos.Get.ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, Dtos.Get.ContactType>();
            CreateMap<Dtos.Get.EntityFavourites, Models.EntityFavourites>();
            CreateMap<Models.EntityFavourites, Dtos.Get.EntityFavourites>();
            CreateMap<Dtos.Get.EntityType, Models.EntityType>();
            CreateMap<Models.EntityType, Dtos.Get.EntityType>();
            CreateMap<Dtos.Get.FavouriteType, Models.FavouriteType>();
            CreateMap<Models.FavouriteType, Dtos.Get.FavouriteType>();
            CreateMap<Dtos.Get.Feature, Models.Feature>();
            CreateMap<Models.Feature, Dtos.Get.Feature>();
            CreateMap<Dtos.Get.Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Dtos.Get.Keyword>();
            CreateMap<Dtos.Get.PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, Dtos.Get.PointOfInterest>();
            CreateMap<Dtos.Get.ProductFavourites, Models.ProductFavourites>();
            CreateMap<Models.ProductFavourites, Dtos.Get.ProductFavourites>();
            CreateMap<Dtos.Get.Role, Models.Role>();
            CreateMap<Models.Role, Dtos.Get.Role>();
            CreateMap<Dtos.Get.Service, Models.Service>();
            CreateMap<Models.Service, Dtos.Get.Service>();
            CreateMap<Dtos.Get.SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, Dtos.Get.SectorService>();
        }
    }
}
