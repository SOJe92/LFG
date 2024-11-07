using AutoMapper;

namespace SearchAndRescue.Favourite.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Dtos.Get.EntityFavourite, Models.EntityFavourite>();
            CreateMap<Models.EntityFavourite, Dtos.Get.EntityFavourite>();
            CreateMap<Dtos.Get.FavouriteType, Models.FavouriteType>();
            CreateMap<Models.FavouriteType, Dtos.Get.FavouriteType>();
            CreateMap<Dtos.Get.ProductFavourite, Models.ProductFavourite>();
            CreateMap<Models.ProductFavourite, Dtos.Get.ProductFavourite>();
        }
    }
}
