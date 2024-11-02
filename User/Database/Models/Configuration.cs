using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Models
{
    [Table("settings.configuration")]
    public class Configuration
    {
        [Column("")]
        public Guid[] EntityFavourites { get; set; }

        [Column("")]
        public Guid[] OwnerFavourites { get; set; }

        [Column("")]
        public Guid[] ProductFavourites { get; set; }
    }
}
