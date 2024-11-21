
using ConfigurationBase = SearchAndRescue.User.Dtos.Base.Configuration;

namespace SearchAndRescue.User.Dtos.Put
{
    public class Configuration : ConfigurationBase
    {
        public IEnumerable<Put.Favourite>? Favourites { get; set; }

        public IEnumerable<Put.ContactType>? ContactTypes { get; set; }

        public IEnumerable<Put.Entity>? Entities { get; set; }

        public IEnumerable<Put.Feature>? Features { get; set; }

        public IEnumerable<Put.Keyword>? Keywords { get; set; }

        public IEnumerable<Put.PointOfInterest>? PointOfInterests { get; set; }

        public Put.Role? Role { get; set; }

        public IEnumerable<Put.SectorService>? Sectors { get; set; }

        public IEnumerable<Put.User>? Users { get; set; }

        public IEnumerable<Put.FeaturePermission>? FeaturePermissions { get; set; }

        public Put.Setting? Settings { get; set; }
    }
}
