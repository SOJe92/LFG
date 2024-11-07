using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userpoi")]
    public record PointOfInterest : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("poi_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid PointOfInterestId { get; set; }
    }
}
