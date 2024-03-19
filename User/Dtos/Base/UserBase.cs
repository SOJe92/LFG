using Newtonsoft.Json;

namespace SearchAndRescue.User.Dtos.Base
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class UserBase
    {
        public Guid? Id { get; set; } = null;

        public string? Username { get; set; } = null;

        public string? Email { get; set; } = null;

        public string? Password { get; set; } = null;
    }
}
