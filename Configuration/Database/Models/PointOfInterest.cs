using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("public.poi")]
    public record PointOfInterest : DbEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("x")]
        public long X { get; set; }

        [Column("y")]
        public long Y { get; set; }
    }
}
