using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userentities")]
    public record Entity : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("entity_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid EntityId { get; set; }
    }
}
