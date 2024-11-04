using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Core.Database
{
    public abstract record DbEntity
    {
        [Column("id")]
        [Key]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.InputOutput)]
        public Guid Id { get; set; }
    }
}
