using SearchAndRescue.Search.Contracts.Dtos;

namespace SearchAndRescue.Search.Dtos
{
    public class SearchResponse<T>
    {
        public SearchResponse()
        {
            Results = new List<T> ();
        }

        public List<T> Results { get; set; }
    }
}
