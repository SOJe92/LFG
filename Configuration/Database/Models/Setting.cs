using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("settings.user")]
    public record Setting : DbEntity
    {
        [Column("locationx")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public long LocationX { get; set; }

        [Column("locationy")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public long LocationY { get; set; }

        [Column("budget")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public int[] Budget { get; set; }
    }
}
