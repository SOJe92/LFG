using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("lookup.sectorservices")]
    public record SectorService : DbEntity
    {

        [Column("sector_id")]
        public Guid SectorId { get; set; }

        [Column("service_id")]
        public Guid ServiceId { get; set; }
    }
}
