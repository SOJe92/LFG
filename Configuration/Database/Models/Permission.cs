using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("settings.permissions")]
    public record Permission : DbEntity
    {
        [Column("key")]
        public string Key { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}
