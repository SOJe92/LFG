namespace SearchAndRescue.Favourite.Contracts.Services
{
    public interface IFavourite
    {
        Task<Guid> AddEntityFavouriteAsync(Dtos.Post.UserFavourite userFavourite);
        Task<Guid> AddProductFavouriteAsync(Dtos.Post.UserFavourite userFavourite);
        Task<Dtos.Get.EntityFavourite> GetEntityFavouriteAsync(Dtos.Get.EntityFavourite entityFavourite);

        Task<Dtos.Get.ProductFavourite> GetProductFavouriteAsync(Dtos.Get.ProductFavourite productFavourite);
        Task<bool> DeleteEntityFavouriteAsync(Dtos.Get.EntityFavourite entityFavourite);

        Task<bool> DeleteProductFavouriteAsync(Dtos.Get.ProductFavourite productFavourite);
        Task<IEnumerable<Dtos.Get.FavouriteType>> GetFavouriteTypesAsync();
        IEnumerable<Dtos.Get.FavouriteType> GetFavouriteTypes();
        Task<Dtos.Get.FavouriteType> GetFavouriteTypeAsync(Dtos.Get.FavouriteType favouriteType);

        Task<IEnumerable<Dtos.Get.EntityFavourite>> GetEntityFavouritesAsync();

        Task<IEnumerable<Dtos.Get.ProductFavourite>> GetProductFavouritesAsync();

        Task<IEnumerable<Dtos.Get.EntityFavourite>> GetEntityFavouritesAsync(Dtos.Get.EntityFavourite entityFavourite);

        Task<IEnumerable<Dtos.Get.ProductFavourite>> GetProductFavouritesAsync(Dtos.Get.ProductFavourite productFavourite);
    }
}
