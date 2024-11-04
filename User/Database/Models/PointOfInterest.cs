using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userpoi")]
    public record PointOfInterest : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("poi_id")]
        public Guid PointOfInterestId { get; set; }
    }
}
