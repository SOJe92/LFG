namespace SearchAndRescue.Configuration.Dtos.Get
{
    public class Configuration
    {
        public Configuration()
        {
            Categories = new List<Category.Dtos.Get.Category>();
            ContactTypes = new List<ContactType.Dtos.Get.ContactType>();
            EntityFavourites = new List<Favourite.Dtos.Get.EntityFavourite>();
            EntityTypes = new List<Entity.Dtos.Get.EntityType>();
            FavouriteTypes = new List<Favourite.Dtos.Get.FavouriteType>();
            Features = new List<Feature.Dtos.Get.Feature>();
            FeaturePermissions = new List<Feature.Dtos.Get.FeaturePermission>();
            Keywords = new List<Keyword.Dtos.Get.Keyword>();
            Permissions = new List<Dtos.Get.Permission>();
            PointOfInterests = new List<POI.Dtos.Get.PointOfInterest>();
            ProductFavourites = new List<Favourite.Dtos.Get.ProductFavourite>();
            Roles = new List<Role.Dtos.Get.Role>();
            Sectors = new List<Sectors.Dtos.Get.Sector>();
            SectorServices = new List<Sectors.Dtos.Get.SectorService>();
            Services = new List<Sectors.Dtos.Get.Service>();
        }

        public IEnumerable<Category.Dtos.Get.Category> Categories { get; set; }
        public IEnumerable<ContactType.Dtos.Get.ContactType> ContactTypes { get; set; }
        public IEnumerable<Favourite.Dtos.Get.EntityFavourite> EntityFavourites { get; set; }
        public IEnumerable<Entity.Dtos.Get.EntityType> EntityTypes { get; set; }
        public IEnumerable<Favourite.Dtos.Get.FavouriteType> FavouriteTypes { get; set; }
        public IEnumerable<Feature.Dtos.Get.Feature> Features { get; set; }
        public IEnumerable<Feature.Dtos.Get.FeaturePermission> FeaturePermissions { get; set; }
        public IEnumerable<Keyword.Dtos.Get.Keyword> Keywords { get; set; }
        public IEnumerable<Dtos.Get.Permission> Permissions { get; set; }
        public IEnumerable<POI.Dtos.Get.PointOfInterest> PointOfInterests { get; set; }
        public IEnumerable<Favourite.Dtos.Get.ProductFavourite> ProductFavourites { get; set; }
        public IEnumerable<Role.Dtos.Get.Role> Roles { get; set; }
        public IEnumerable<Sectors.Dtos.Get.Sector> Sectors { get; set; }
        public IEnumerable<Sectors.Dtos.Get.SectorService> SectorServices { get; set; }
        public IEnumerable<Sectors.Dtos.Get.Service> Services { get; set; }

    }
}
