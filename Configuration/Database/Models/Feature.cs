using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("settings.features")]
    public record Feature : DbEntity
    {
        [Column("key")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Key { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Description { get; set; }

        [Column("enabled")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public bool Enabled { get; set; }
    }
}
