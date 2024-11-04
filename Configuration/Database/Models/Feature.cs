using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("settings.features")]
    public record Feature : DbEntity
    {
        [Column("key")]
        public string Key { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("enabled")]
        public bool Enabled { get; set; }
    }
}
