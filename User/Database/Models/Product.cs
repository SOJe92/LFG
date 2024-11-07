using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userproducts")]
    public record Product : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("product_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid ProductId { get; set; }
    }
}
