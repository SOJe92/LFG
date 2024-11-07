using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userfavourites")]
    public record Favourite : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("favourite_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid FavouriteId { get; set; }

        [Column("resource_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid ResourceId { get; set; }

        [Column("type_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid TypeId { get; set; }
    }
}
