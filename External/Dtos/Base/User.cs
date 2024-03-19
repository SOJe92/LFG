using Newtonsoft.Json;

namespace SearchAndRescue.External.Dtos.Base
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class User : SearchAndRescue.User.Dtos.Base.UserBase
    {
    }
}
