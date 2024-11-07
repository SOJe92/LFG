using ProductFavouriteBase = SearchAndRescue.Favourite.Dtos.Base.ProductFavourite;

namespace SearchAndRescue.Favourite.Dtos.Get
{
    public class ProductFavourite : ProductFavouriteBase
    {
        public Guid Id { get; set; }
    }
}
