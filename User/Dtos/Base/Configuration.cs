using Newtonsoft.Json;

namespace SearchAndRescue.User.Dtos.Base
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Configuration
    {
        public IEnumerable<Favourite> Favourites { get; set; }

        public IEnumerable<ContactType> ContactTypes { get; set; }

        public IEnumerable<Entity> Entities { get; set; }

        public IEnumerable<Feature> Features { get; set; }

        public IEnumerable<Keyword> Keywords { get; set; }

        public IEnumerable<PointOfInterest> PointOfInterests { get; set; }

        public Role Role { get; set; }

        public IEnumerable<SectorService> Sectors { get; set; }

        public IEnumerable<User> Users { get; set; }

        public Setting Settings { get; set; }
    }
}
