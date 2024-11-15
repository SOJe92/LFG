using AutoMapper;

namespace SearchAndRescue.User.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            MapBase();
            MapGet();
            MapPost();
            MapPut();
        }

        private void MapBase()
        {
            CreateMap<Dtos.Base.User, Models.User>();
            CreateMap<Models.User, Dtos.Base.User>();
            CreateMap<Dtos.Base.ChildUser, Models.ChildUser>();
            CreateMap<Models.ChildUser, Dtos.Base.ChildUser>();
            CreateMap<Dtos.Base.ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, Dtos.Base.ContactType>();
            CreateMap<Dtos.Base.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Base.Entity>();
            CreateMap<Dtos.Base.Favourite, Models.Favourite>();
            CreateMap<Models.Favourite, Dtos.Base.Favourite>();
            CreateMap<Dtos.Base.FeaturePermission, Models.FeaturePermission>();
            CreateMap<Models.FeaturePermission, Dtos.Base.FeaturePermission>();
            CreateMap<Dtos.Base.Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Dtos.Base.Keyword>();
            CreateMap<Dtos.Base.PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, Dtos.Base.PointOfInterest>();
            CreateMap<Dtos.Base.Role, Models.Role>();
            CreateMap<Models.Role, Dtos.Base.Role>();
            CreateMap<Dtos.Base.SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, Dtos.Base.SectorService>();
            CreateMap<Dtos.Base.Setting, Models.Setting>();
            CreateMap<Models.Setting, Dtos.Base.Setting>();
        }

        private void MapGet()
        {
            CreateMap<Dtos.Get.LoginUser, Models.User>();
            CreateMap<Models.User, Dtos.Get.LoginUser>();
            CreateMap<Dtos.Get.User, Models.User>();
            CreateMap<Models.User, Dtos.Get.User>();
            CreateMap<Dtos.Get.ChildUser, Models.ChildUser>();
            CreateMap<Models.ChildUser, Dtos.Get.ChildUser>();
            CreateMap<Dtos.Get.ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, Dtos.Get.ContactType>();
            CreateMap<Dtos.Get.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Get.Entity>();
            CreateMap<Dtos.Get.Favourite, Models.Favourite>();
            CreateMap<Models.Favourite, Dtos.Get.Favourite>();
            CreateMap<Dtos.Get.Feature, Models.FeaturePermission>();
            CreateMap<Models.FeaturePermission, Dtos.Get.Feature>();
            CreateMap<Dtos.Get.Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Dtos.Get.Keyword>();
            CreateMap<Dtos.Get.PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, Dtos.Get.PointOfInterest>();
            CreateMap<Dtos.Get.Role, Models.Role>();
            CreateMap<Models.Role, Dtos.Get.Role>();
            CreateMap<Dtos.Get.SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, Dtos.Get.SectorService>();
            CreateMap<Dtos.Get.Setting, Models.Setting>();
            CreateMap<Models.Setting, Dtos.Get.Setting>();
        }

        private void MapPost()
        {
            CreateMap<Dtos.Post.User, Models.User>();
            CreateMap<Models.User, Dtos.Post.User>();
            CreateMap<Dtos.Post.ChildUser, Models.ChildUser>();
            CreateMap<Models.ChildUser, Dtos.Post.ChildUser>();
            CreateMap<Dtos.Post.ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, Dtos.Post.ContactType>();
            CreateMap<Dtos.Post.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Post.Entity>();
            CreateMap<Dtos.Post.Favourite, Models.Favourite>();
            CreateMap<Models.Favourite, Dtos.Post.Favourite>();
            CreateMap<Dtos.Post.Feature, Models.FeaturePermission>();
            CreateMap<Models.FeaturePermission, Dtos.Post.Feature>();
            CreateMap<Dtos.Post.Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Dtos.Post.Keyword>();
            CreateMap<Dtos.Post.PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, Dtos.Post.PointOfInterest>();
            CreateMap<Dtos.Post.Role, Models.Role>();
            CreateMap<Models.Role, Dtos.Post.Role>();
            CreateMap<Dtos.Post.SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, Dtos.Post.SectorService>();
            CreateMap<Dtos.Post.Setting, Models.Setting>();
            CreateMap<Models.Setting, Dtos.Post.Setting>();
        }

        private void MapPut()
        {
            CreateMap<Dtos.Put.User, Models.User>();
            CreateMap<Models.User, Dtos.Put.User>();
            CreateMap<Dtos.Put.ChildUser, Models.ChildUser>();
            CreateMap<Models.ChildUser, Dtos.Put.ChildUser>();
            CreateMap<Dtos.Put.ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, Dtos.Put.ContactType>();
            CreateMap<Dtos.Put.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Put.Entity>();
            CreateMap<Dtos.Put.Favourite, Models.Favourite>();
            CreateMap<Models.Favourite, Dtos.Put.Favourite>();
            CreateMap<Dtos.Put.Feature, Models.FeaturePermission>();
            CreateMap<Models.FeaturePermission, Dtos.Put.Feature>();
            CreateMap<Dtos.Put.Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Dtos.Put.Keyword>();
            CreateMap<Dtos.Put.PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, Dtos.Put.PointOfInterest>();
            CreateMap<Dtos.Put.Role, Models.Role>();
            CreateMap<Models.Role, Dtos.Put.Role>();
            CreateMap<Dtos.Put.SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, Dtos.Put.SectorService>();
            CreateMap<Dtos.Put.Setting, Models.Setting>();
            CreateMap<Models.Setting, Dtos.Put.Setting>();
        }
    }
}
