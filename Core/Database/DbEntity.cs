using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Core.Database
{
    public abstract class DbEntity
    {
        [Column("id")]
        [DapperParamDirectionAttribute(System.Data.ParameterDirection.InputOutput)]
        public Guid Id { get; set; }
    }
}
