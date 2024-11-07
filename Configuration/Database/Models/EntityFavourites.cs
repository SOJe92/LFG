using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("public.favourite_entities")]
    public record EntityFavourites : DbEntity
    {
        [Column("entity_id")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public Guid EntityId { get; set; }
    }
}
