using SearchAndRescue.Search.Contracts.Dtos;
using SearchAndRescue.Search.Contracts.Services;
using SearchAndRescue.Search.Dtos;

namespace SearchAndRescue.Search.Services
{
    public class ProductSearchResponseService : ISearchResponseService<ProductsSearchResult>
    {
        public SearchResponse<ProductsSearchResult> Execute()
        {
            SearchResponse<ProductsSearchResult> response = new SearchResponse<ProductsSearchResult>();
            ProductsSearchResult result = new ProductsSearchResult
            {
                Id = new Guid(),
                Name = "Test Name",
                Keywords = new string[] { "Black", "Cis" },
                SectorID = new Guid(),
                Seller = new Guid(),
                Distance = 1000
            };
            response.Results.Add(result);
            return response;
        }
    }
}
