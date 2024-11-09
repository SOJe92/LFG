using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Entity.Database.Models
{
    [Table("public.entitytype")]
    public record EntityType : DbEntity
    {
        [Column("name")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Name { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Description { get; set; }
    }
}
