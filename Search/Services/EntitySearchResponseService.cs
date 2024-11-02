using SearchAndRescue.Search.Contracts.Services;
using SearchAndRescue.Search.Dtos;

namespace SearchAndRescue.Search.Services
{
    public class EntitySearchResponseService : ISearchResponseService<EntitiesSearchResult>
    {
        public SearchResponse<EntitiesSearchResult> Execute()
        {
            SearchResponse<EntitiesSearchResult> response = new();
            EntitiesSearchResult result = new()
            {
                Id = new Guid(),
                Name = "Test Name",
                Keywords = new string[] { "Black", "Cis" },
                SectorID = new Guid(),
                PurchaseMethod = "Service",
                Verified = false
            };
            response.Results.Add(result);
            return response;
        }
    }
}
