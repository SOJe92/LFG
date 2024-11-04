using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userrole")]
    public record Role : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("role_id")]
        public Guid RoleId { get; set; }
    }
}
