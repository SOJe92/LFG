using Newtonsoft.Json;
using SearchAndRescue.User.Dtos.Base;

namespace SearchAndRescue.User.Dtos.Post
{
    public class User : Base.User
    {
        [JsonProperty]
        public string? FirstName { get; set; }

        [JsonProperty]
        public string? LastName { get; set; }

        [JsonProperty]
        public string? Address1 { get; set; }

        [JsonProperty]
        public string? Address2 { get; set; }

        [JsonProperty]
        public string? City { get; set; }

        [JsonProperty]
        public string? Region { get; set; }

        [JsonProperty]
        public string? PostalCode { get; set; }

        [JsonProperty]
        public string? Country { get; set; }

        [JsonProperty]
        public string? Phone { get; set; }
    }
}
