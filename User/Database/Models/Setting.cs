using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("settings.user")]
    public class Setting
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("locationx")]
        public long LocationX { get; set; }

        [Column("locationy")]
        public long LocationY { get; set; }

        [Column("budget")]
        public int[] Budget { get; set; }
    }
}
