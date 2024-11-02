using SearchAndRescue.Search.Contracts.Dtos;

namespace SearchAndRescue.Search.Dtos
{
    public class ProductsSearchResult : ISearchResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string[] Keywords { get; set; }

        public int Distance { get; set; }

        public Guid Seller { get; set; }

        public Guid SectorID { get; set; }
    }
}
