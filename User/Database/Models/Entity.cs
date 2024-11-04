using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userentities")]
    public record Entity : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("entity_id")]
        public Guid EntityId { get; set; }
    }
}
