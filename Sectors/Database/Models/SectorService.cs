using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Sectors.Database.Models
{
    [Table("lookup.sectorservices")]
    public record SectorService : DbEntity
    {

        [Column("sector_id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid SectorId { get; set; }

        [Column("service_id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid ServiceId { get; set; }
    }
}
