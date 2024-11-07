using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("public.contacttype")]
    public record ContactType : DbEntity
    {
        [Column("name")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Name { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Description { get; set; }
    }
}
