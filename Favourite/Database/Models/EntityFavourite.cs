using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Favourite.Database.Models
{
    [Table("public.favourite_entities")]
    public record EntityFavourite : DbEntity
    {
        [Column("entity_id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid EntityId { get; set; }
    }
}
