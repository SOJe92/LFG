using Newtonsoft.Json;

namespace SearchAndRescue.User.Dtos.Base
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Configuration
    {
        public Guid[] EntityFavourites { get; set; }

        public Guid[] OwnerFavourites { get; set; }

        public Guid[] ProductFavourites { get; set; }

        public Setting Settings { get; set; }
    }
}
