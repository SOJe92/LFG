namespace SearchAndRescue.Favourite.Contracts.Repositories
{
    public interface IFavourite
    {
        Task<IEnumerable<Database.Models.EntityFavourite>> GetEntityFavouritesAsync();
        Task<IEnumerable<Database.Models.EntityFavourite>> GetEntityFavouritesAsync(Database.Models.EntityFavourite entityFavourite);
        Task<Database.Models.EntityFavourite> GetEntityFavouriteAsync(Database.Models.EntityFavourite entityFavourite);
        Task<Guid> AddEntityFavouriteAsync(Database.Models.UserFavourite entityFavourite);
        Task<bool> DeleteEntityFavouriteAsync(Database.Models.UserFavourite entityFavourite);
        Task<IEnumerable<Database.Models.ProductFavourite>> GetProductFavouritesAsync();
        Task<IEnumerable<Database.Models.ProductFavourite>> GetProductFavouritesAsync(Database.Models.ProductFavourite productFavourite);
        Task<Database.Models.ProductFavourite> GetProductFavouriteAsync(Database.Models.ProductFavourite productFavourite);
        Task<Guid> AddProductFavouriteAsync(Database.Models.UserFavourite productFavourite);
        Task<bool> DeleteProductFavouriteAsync(Database.Models.UserFavourite productFavourite);

        Task<IEnumerable<Database.Models.FavouriteType>> GetFavouriteTypesAsync();
        IEnumerable<Database.Models.FavouriteType> GetFavouriteTypes();
        Task<Database.Models.FavouriteType> GetFavouriteTypeAsync(Database.Models.FavouriteType favouriteType);
    }
}
