using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usersectorservices")]
    public record SectorService : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("sector_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid SectorId { get; set; }

        [Column("service_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid ServiceId { get; set; }
    }
}
