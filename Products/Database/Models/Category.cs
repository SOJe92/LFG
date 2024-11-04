using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Products.Database.Models
{
    [Table("lookup.productcategory")]
    public record Category : DbEntity
    {
        [Column("product_id")]
        public Guid ProductId { get; set; }

        [Column("category_id")]
        public Guid CategoryId { get; set; }
    }
}
