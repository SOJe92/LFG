using KeywordBase = SearchAndRescue.User.Dtos.Base.Keyword;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Keyword : KeywordBase
    {
        public Guid Id { get; set; }
    }
}
