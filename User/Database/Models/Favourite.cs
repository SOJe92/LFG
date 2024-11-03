using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userfavourites")]
    public class Favourite
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("favourite_id")]
        public Guid FavouriteId { get; set; }

        [Column("resource_id")]
        public Guid ResourceId { get; set; }

        [Column("type_id")]
        public Guid TypeId { get; set; }
    }
}
