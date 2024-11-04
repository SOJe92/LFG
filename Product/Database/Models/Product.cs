using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Product.Database.Models
{
    [Table("public.products")]
    public record Product : DbEntity
    {
        [Column("name")]
        public string Name { get; set; }
    }
}
