using SearchAndRescue.Core.Database;
using SearchAndRescue.Core.Database.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Database.Models
{
    [Table("lookup.userkeywords")]
    public record Keyword : DbEntity
    {
        [Column("user_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid UserId { get; set; }

        [Column("keywords_id")]
        [DapperParamDirection(System.Data.ParameterDirection.Input)]
        public Guid KeywordId { get; set; }
    }
}
