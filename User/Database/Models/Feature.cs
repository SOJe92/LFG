using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userfeatures")]
    public record Feature : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("feature_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid FeatureId { get;set; }

        [Column("enabled")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public bool Enabled { get; set; }
    }
}
