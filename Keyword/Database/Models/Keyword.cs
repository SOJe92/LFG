using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Keyword.Database.Models
{
    [Table("public.keywords")]
    public record Keyword : DbEntity
    {
        [Column("name")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Name { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Description { get; set; }
    }
}
