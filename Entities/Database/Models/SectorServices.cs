using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Entities.Database.Models
{
    [Table("lookup.entitysectorservices")]
    public record SectorServices : DbEntity
    {
        [Column("entity_id")]
        public Guid EntityId { get; set; }

        [Column("sector_id")]
        public Guid SectorId { get; set; }

        [Column("service_id")]
        public Guid ServiceId { get; set; }
    }
}
