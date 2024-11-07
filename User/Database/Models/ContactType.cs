using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usercontacttypes")]
    public record ContactType : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("contacttype_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid ContactTypeId { get; set; }

        [Column("value")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public string Value { get; set; }
    }
}
