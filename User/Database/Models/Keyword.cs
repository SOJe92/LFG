using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userkeywords")]
    public record Keyword : DbEntity
    {
        [Column("user_id")]
        public Guid UserId { get; set; }

        [Column("keywords_id")]
        public Guid KeywordId { get; set; }
    }
}
