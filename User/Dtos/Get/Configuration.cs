using ConfigurationBase = SearchAndRescue.User.Dtos.Base.Configuration;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Configuration : ConfigurationBase
    {
        public Guid Id { get; set; }

        public IEnumerable<Get.Favourite> Favourites { get; set; }

        public IEnumerable<Get.ContactType> ContactTypes { get; set; }

        public IEnumerable<Get.Entity> Entities { get; set; }

        public IEnumerable<Get.Feature> Features { get; set; }

        public IEnumerable<Get.Keyword> Keywords { get; set; }

        public IEnumerable<Get.PointOfInterest> PointOfInterests { get; set; }

        public Get.Role Role { get; set; }

        public IEnumerable<Get.SectorService> Sectors { get; set; }

        public IEnumerable<Get.User> Users { get; set; }

        public IEnumerable<Get.FeaturePermission> FeaturePermissions { get; set; }

        public Get.Setting Settings { get; set; }
    }
}
