using Newtonsoft.Json;
using SearchAndRescue.User.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace SearchAndRescue.User.Dtos.Get
{
    public class LoginUser : UserBase
    {
        [JsonProperty]
        public string DisplayName { get; set; }

        public IEnumerable<FeaturePermission> FeaturePermissions { get; set; }
    }
}
