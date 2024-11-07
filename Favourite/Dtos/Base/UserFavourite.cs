namespace SearchAndRescue.Favourite.Dtos.Base
{
    public class UserFavourite
    {
        public Guid UserId { get; set; }

        public Guid FavouriteId { get; set; }

        public Guid ResourceId { get; set; }

        public Guid TypeId { get; set; }
    }
}
