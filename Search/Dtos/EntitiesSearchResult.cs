using SearchAndRescue.Search.Contracts.Dtos;

namespace SearchAndRescue.Search.Dtos
{
    public class EntitiesSearchResult : ISearchResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string[] Keywords { get; set; }

        public bool Verified { get; set; }

        public string PurchaseMethod { get; set; }

        public Guid SectorID { get; set; }
    }
}
