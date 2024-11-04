using Newtonsoft.Json;

namespace SearchAndRescue.User.Dtos.Base
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class User
    {
        public Guid? Id { get; set; } = null;

        public string? Username { get; set; } = null;

        public string? Email { get; set; } = null;

        public string? Password { get; set; } = null;

        public bool? IsAdmin { get; set; }

        public bool? IsEmailConfirmed { get; set; }

        public DateTime? LastLogin { get; set; }

        public string Addr1 { get; set; }

        public string Addr2 { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Locale { get; set; }

        public string Image { get; set; }

        public string Location { get; set; }

        public long X { get; set; }

        public long Y { get; set; }

        public Configuration Configuration { get; set; }
    }
}
