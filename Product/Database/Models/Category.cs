using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Product.Database.Models
{
    [Table("lookup.productcategory")]
    public class Category : DbEntity
    {
        [Column("product_id")]
        public Guid ProductId { get; set; }

        [Column("category_id")]
        public Guid CategoryId { get; set; }
    }
}
