namespace SearchAndRescue.User.Contracts.Services
{
    public interface IUser
    {
        Task<IEnumerable<Dtos.Get.Keyword>> GetKeywordsAsync(Guid userId);
        Task<Dtos.Get.Keyword> GetKeywordAsync(Dtos.Get.Keyword keyword);
        Task<Guid> AddKeywordAsync(Dtos.Post.Keyword keyword);
        Task<bool> DeleteKeywordAsync(Guid id);
        Task<IEnumerable<Dtos.Get.ContactType>> GetContactTypesAsync(Guid userId);
        Task<Guid> AddContactTypeAsync(Dtos.Post.ContactType contactType);
        Task<bool> DeleteContactTypeAsync(Guid id);
        Task<IEnumerable<Dtos.Get.Entity>> GetEntitiesAsync(Guid userId);
        Task<Dtos.Get.Entity> GetEntityAsync(Dtos.Get.Entity entity);
        Task<Guid> AddEntityAsync(Dtos.Post.Entity entity);
        Task<bool> DeleteEntityAsync(Guid userId, Guid id);
        Task<IEnumerable<Dtos.Get.Product>> GetProductsAsync(Guid userId);
        Task<Dtos.Get.Product> GetProductAsync(Dtos.Get.Product product);
        Task<Guid> AddProductAsync(Dtos.Post.Product product);
        Task<bool> DeleteProductAsync(Guid userId, Guid id);
        Task<Dtos.Get.Favourite> GetFavouriteAsync(Dtos.Get.Favourite favourite);
        Task<IEnumerable<Dtos.Get.Favourite>> GetFavouritesAsync(Guid userId);
        Task<Guid> AddFavouriteAsync(Dtos.Post.Favourite favourite);
        Task<bool> DeleteFavouriteAsync(Guid id);
        Task<IEnumerable<Dtos.Get.Feature>> GetFeaturesAsync(Guid userId);
        Task<Dtos.Get.Feature> GetFeatureAsync(Dtos.Get.Feature feature);
        Task<bool> UpdateFeatureAsync(Dtos.Post.Feature feature);
        Task<Dtos.Get.PointOfInterest> GetPointOfInterestAsync(Dtos.Get.PointOfInterest poi);
        Task<IEnumerable<Dtos.Get.PointOfInterest>> GetPointOfInterestsAsync(Guid userId);
        Task<Guid> AddPointOfInterestAsync(Dtos.Post.PointOfInterest poi);
        Task<bool> DeletePointOfInterestAsync(Guid userId, Guid id);
        Task<Dtos.Get.Role> GetRoleAsync(Guid userId);
        Task<bool> SetRoleAsync(Dtos.Post.Role role);
        Task<IEnumerable<Dtos.Get.ChildUser>> GetUsersAsync(Guid userId);
        Task<Dtos.Get.ChildUser> GetUserAsync(Dtos.Get.ChildUser user);
        Task<Guid> AddUserAsync(Dtos.Post.ChildUser user);
        Task<bool> DeleteUserAsync(Guid id);
        Task<IEnumerable<Dtos.Get.SectorService>> GetSectorServicesAsync(Guid userId);
        Task<Dtos.Get.SectorService> GetSectorAsync(Dtos.Get.SectorService sectorService);
        Task<Dtos.Get.SectorService> GetSectorServiceAsync(Dtos.Get.SectorService sectorService);
        Task<Guid> AddSectorServiceAsync(Dtos.Post.SectorService sectorService);
        Task<bool> DeleteSectorServiceAsync(Guid id);
        Task<Dtos.Get.Setting> GetSettingAsync(Guid userId);
        Task<Guid> CreateSettingsAsync(Dtos.Post.Setting setting);
        Task<bool> UpdateSettingsAsync(Dtos.Post.Setting setting);
    }
}
