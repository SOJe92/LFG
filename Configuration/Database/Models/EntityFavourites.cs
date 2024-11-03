using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("public.favourite_entities")]
    public class EntityFavourites : DbEntity
    {
        [Column("entity_id")]
        public Guid EntityId { get; set; }
    }
}
