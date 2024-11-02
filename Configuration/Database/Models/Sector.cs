using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Models
{
    [Table("settings.sectors")]
    public class Sector
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
