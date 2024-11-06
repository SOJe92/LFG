using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userusers")]
    public record ChildUser : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("child_user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid ChildUserId { get; set; }
    }
}
