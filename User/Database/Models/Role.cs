using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userrole")]
    public record Role : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid UserId { get; set; }

        [Column("role_id", TypeName = "uuid")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid RoleId { get; set; }
    }
}
