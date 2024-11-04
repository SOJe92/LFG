using System.ComponentModel.DataAnnotations.Schema;

namespace SearchAndRescue.User.Dtos.Base
{
    public class Keyword
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid KeywordId { get; set; }
    }
}
