using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("settings.user")]
    public record Setting : DbEntity
    {
        [Column("locationx")]
        public long LocationX { get; set; }

        [Column("locationy")]
        public long LocationY { get; set; }

        [Column("budget")]
        public int[] Budget { get; set; }
    }
}
