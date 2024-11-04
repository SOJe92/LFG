using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("public.favourite_products")]
    public record ProductFavourites : DbEntity
    {
        [Column("product_id")]
        public Guid ProductId { get; set; }
    }
}
