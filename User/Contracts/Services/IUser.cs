namespace SearchAndRescue.User.Contracts.Services
{
    public interface IUser
    {
        Task<IEnumerable<Dtos.Get.Keyword>> GetKeywordsAsync(Guid userId);
        Task<Dtos.Get.Keyword> GetKeywordAsync(Guid userId, Guid Id);
        Task<Guid> AddKeywordAsync(Dtos.Post.Keyword keyword);
        Task<bool> DeleteKeywordAsync(Guid id);
        Task<IEnumerable<Dtos.Get.ContactType>> GetContactTypesAsync(Guid userId);
        Task<Guid> AddContactTypeAsync(Dtos.Post.ContactType contactType);
        Task<bool> DeleteContactTypeAsync(Guid id);
        Task<IEnumerable<Dtos.Get.Entity>> GetEntitiesAsync(Guid userId);
        Task<Dtos.Get.Entity> GetEntityAsync(Guid userId, Guid id);
        Task<Guid> AddEntityAsync(Dtos.Post.Entity entity);
        Task<bool> DeleteEntityAsync(Guid id);
        Task<Dtos.Get.Favourite> GetFavouriteAsync(Guid userId, Guid id);
        Task<IEnumerable<Dtos.Get.Favourite>> GetFavouritesAsync(Guid userId);
        Task<Guid> AddFavouriteAsync(Dtos.Post.Favourite favourite);
        Task<bool> DeleteFavouriteAsync(Guid id);
        Task<IEnumerable<Dtos.Get.Feature>> GetFeaturesAsync(Guid userId);
        Task<Dtos.Get.Feature> GetFeatureAsync(Guid userId, Guid id);
        Task<Guid> UpdateFeatureAsync(Dtos.Post.Feature feature);
        Task<Dtos.Get.PointOfInterest> GetPointOfInterestAsync(Guid userId, Guid id);
        Task<IEnumerable<Dtos.Get.PointOfInterest>> GetPointOfInterestsAsync(Guid userId);
        Task<Guid> AddPointOfInterestAsync(Dtos.Post.PointOfInterest poi);
        Task<bool> DeletePointOfInterestAsync(Guid userId, Guid Id);
        Task<Dtos.Get.Role> GetRoleAsync(Guid userId);
        Task<bool> SetRoleAsync(Dtos.Post.Role role);
        Task<IEnumerable<Dtos.Get.User>> GetUsersAsync(Guid userId);
        Task<Dtos.Get.User> GetUserAsync(Guid userId, Guid id);
        Task<Guid> AddUserAsync(Dtos.Post.User user);
        Task<bool> DeleteUserAsync(Guid id);
        Task<IEnumerable<Dtos.Get.SectorService>> GetSectorServicesAsync(Guid userId);
        Task<Dtos.Get.SectorService> GetSectorAsync(Guid userId, Guid sectorId);
        Task<Dtos.Get.SectorService> GetSectorServiceAsync(Guid userId, Guid sectorId, Guid serviceId);
        Task<Guid> AddSectorServiceAsync(Dtos.Post.SectorService sectorService);
        Task<bool> DeleteSectorServiceAsync(Guid id);
        Task<Dtos.Get.Setting> GetSettingAsync(Guid userId);
        Task<Guid> CreateSettingsAsync(Dtos.Post.Setting setting);
        Task<bool> UpdateSettingsAsync(Dtos.Post.Setting setting);
    }
}
