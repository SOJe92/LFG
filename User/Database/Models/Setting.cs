using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.usersettings")]
    public record Setting : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("settings_id")]
        public Guid SettingId { get; set; }
    }
}
