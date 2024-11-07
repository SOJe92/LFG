using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Favourite.Database.Models
{
    [Table("public.favourite_products")]
    public record ProductFavourite : DbEntity
    {
        [Column("product_id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid ProductId { get; set; }
    }
}
