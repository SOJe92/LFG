using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Products.Database.Models
{
    [Table("lookup.productkeywords")]
    public record Keyword : DbEntity
    {
        [Column("product_id")]
        public Guid ProductId { get; set; }

        [Column("keyword_id")]
        public Guid KeywordId { get; set; }
    }
}
