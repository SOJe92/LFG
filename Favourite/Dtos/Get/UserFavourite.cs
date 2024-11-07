using UserFavouriteBase = SearchAndRescue.Favourite.Dtos.Base.UserFavourite;

namespace SearchAndRescue.Favourite.Dtos.Get
{
    public class UserFavourite : UserFavouriteBase
    {
        public Guid Id { get; set; }
    }
}
