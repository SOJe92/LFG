using Newtonsoft.Json;

namespace SearchAndRescue.User.Dtos.Base
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Configuration
    {
        public IEnumerable<Get.Favourite> Favourites { get; set; }

        public IEnumerable<Get.ContactType> ContactTypes { get; set; }

        public IEnumerable<Get.Entity> Entities { get; set; }

        public IEnumerable<Get.Feature> Features { get; set; }

        public IEnumerable<Get.Keyword> Keywords { get; set; }

        public IEnumerable<Get.PointOfInterest> PointOfInterests { get; set; }

        public Get.Role Role { get; set; }

        public IEnumerable<Get.SectorService> Sectors { get; set; }

        public IEnumerable<Get.User> Users { get; set; }

        public Get.Setting Settings { get; set; }
    }
}
