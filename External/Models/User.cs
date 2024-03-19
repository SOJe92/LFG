using SearchAndRescue.Core.Database.Attributes;
using SearchAndRescue.User.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.External.Models
{
    [Table("account.users")]
    public record ExternalUser : User.Models.User 
    {
    }
}
