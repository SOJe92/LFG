using FavouriteTypeBase = SearchAndRescue.Favourite.Dtos.Base.FavouriteType;
namespace SearchAndRescue.Favourite.Dtos.Get
{
    public class FavouriteType : FavouriteTypeBase
    {
        public Guid Id { get; set; }

    }
}
