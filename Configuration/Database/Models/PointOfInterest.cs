using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Configuration.Database.Models
{
    [Table("public.poi")]
    public record PointOfInterest : DbEntity
    {
        [Column("name")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Name { get; set; }

        [Column("description")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public string Description { get; set; }

        [Column("x")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public long X { get; set; }

        [Column("y")]
        [DapperParamDirection(System.Data.ParameterDirection.InputOutput)]
        public long Y { get; set; }
    }
}
