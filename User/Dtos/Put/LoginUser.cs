using Newtonsoft.Json;
using SearchAndRescue.User.Dtos.Base;
using System.ComponentModel.DataAnnotations;

namespace SearchAndRescue.User.Dtos.Put
{
    public class LoginUser : Base.User
    {
        [JsonProperty]
        public string DisplayName { get; set; }
    }
}
