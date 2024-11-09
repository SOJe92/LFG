using KeywordBase = SearchAndRescue.Keyword.Dtos.Base.Keyword;

namespace SearchAndRescue.Keyword.Dtos.Get
{
    public class Keyword : KeywordBase
    {
        public Guid Id { get; set; }
    }
}
