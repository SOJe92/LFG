using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Products.Database.Models
{
    [Table("public.products")]
    public class Products : DbEntity
    {
        [Column("name")]
        public string Name { get; set; }
    }
}
