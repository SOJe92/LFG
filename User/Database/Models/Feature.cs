using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("settings.features")]
    public class Feature
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("key")]
        public string Key { get; set; }

        [Column("description")]
        public string Description { get;set; }

        [Column("enabled")]
        public bool Enabled { get; set; }
    }
}
