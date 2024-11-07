using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Core.Database
{
    public abstract record DbEntity
    {
        [Column("id")]
        [Key]
        [DapperParamDirection(System.Data.ParameterDirection.Output)]
        public Guid Id { get; set; }
    }
}
