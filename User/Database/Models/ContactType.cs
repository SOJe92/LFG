using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usercontacttypes")]
    public record ContactType : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("contacttype_id")]
        public Guid ContactTypeId { get; set; }

        [Column("value")]
        public string Value { get; set; }
    }
}
