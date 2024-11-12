using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userfeaturepermissions")]
    public record FeaturePermission : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("feature_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid FeatureId { get; set; }

        [Column("permission_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid PermissionId { get; set; }

        [Column("enabled")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public bool Enabled { get; set; }
    }
}
