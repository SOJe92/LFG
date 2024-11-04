using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usercontacttype")]
    public record ContactType : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("contacttype_id")]
        public Guid ContactTypeId { get; set; }
    }
}
