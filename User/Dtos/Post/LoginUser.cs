using Newtonsoft.Json;
using SearchAndRescue.User.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace SearchAndRescue.User.Dtos.Post
{
    public class LoginUser : Base.User
    {
        [JsonProperty]
        public string DisplayName { get; set; }

        public IEnumerable<FeaturePermission> FeaturePermissions { get; set; }
    }
}
