using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Products.Database.Models
{
    [Table("public.products")]
    public record Products : DbEntity
    {
        [Column("name")]
        public string Name { get; set; }
    }
}
