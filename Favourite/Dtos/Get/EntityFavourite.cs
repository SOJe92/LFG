using EntityFavouriteBase = SearchAndRescue.Favourite.Dtos.Base.EntityFavourite;
namespace SearchAndRescue.Favourite.Dtos.Get
{
    public class EntityFavourite : EntityFavouriteBase
    {
        public Guid Id { get; set; }
    }
}
