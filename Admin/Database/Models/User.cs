using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Admin.Database.Models
{
    [Table("account.users")]
    public record User : DbEntity
    {
        [Column("username")]
        public string Username { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}
