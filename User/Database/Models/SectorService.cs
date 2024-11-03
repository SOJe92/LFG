using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usersectorservices")]
    public class SectorService
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("sector_id")]
        public Guid SectorId { get; set; }

        [Column("service_id")]
        public Guid ServiceId { get; set; }
    }
}
