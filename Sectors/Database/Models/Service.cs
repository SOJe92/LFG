using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Sectors.Database.Models
{
    [Table("public.services")]
    public record Service : DbEntity
    {
        [Column("name")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Name { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Description { get; set; }
    }
}
