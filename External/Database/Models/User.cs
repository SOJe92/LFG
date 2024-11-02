using SearchAndRescue.Core.Database.Attributes;
using SearchAndRescue.User.Database.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.External.Database.Models
{
    [Table("account.users")]
    public record ExternalUser : User.Database.Models.User 
    {
    }
}
