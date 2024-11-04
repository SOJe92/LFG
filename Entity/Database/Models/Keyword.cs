using SearchAndRescue.Core.Database;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.Entity.Database.Models
{
    [Table("lookup.entitykeywords")]
    public record Keyword : DbEntity
    {
        [Column("entity_id")]
        public Guid EntityId { get; set; }

        [Column("keyword_id")]
        public Guid KeywordId { get; set; }
    }
}
