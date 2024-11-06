namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IUser
    {
        Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync(Database.Models.Keyword keyword);
        Task<Database.Models.Keyword> GetKeywordAsync(Database.Models.Keyword keyword);
        Task<Guid> AddKeywordAsync(Database.Models.Keyword keyword);
        Task<bool> DeleteKeywordAsync(Database.Models.Keyword keyword);
        Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync(Database.Models.ContactType contactType);
        Task<Guid> AddContactTypeAsync(Database.Models.ContactType contactType);
        Task<bool> DeleteContactTypeAsync(Database.Models.ContactType contactType);
        Task<IEnumerable<Database.Models.Entity>> GetEntitiesAsync(Database.Models.Entity entity);
        Task<Database.Models.Entity> GetEntityAsync(Database.Models.Entity entity);
        Task<Guid> AddEntityAsync(Database.Models.Entity entity);
        Task<bool> DeleteEntityAsync(Database.Models.Entity entity);
        Task<Database.Models.Favourite> GetFavouriteAsync(Database.Models.Favourite favouritw);
        Task<IEnumerable<Database.Models.Favourite>> GetFavouritesAsync(Database.Models.Favourite favouritw);
        Task<Guid> AddFavouriteAsync(Database.Models.Favourite favourite);
        Task<bool> DeleteFavouriteAsync(Database.Models.Favourite favouritw);
        Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync(Database.Models.Feature feature);
        Task<Database.Models.Feature> GetFeatureAsync(Database.Models.Feature feature);
        Task<Guid> UpdateFeatureAsync(Database.Models.Feature feature);
        Task<Database.Models.PointOfInterest> GetPointOfInterestAsync(Database.Models.PointOfInterest poi);
        Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync(Database.Models.PointOfInterest poi);
        Task<Guid> AddPointOfInterestAsync(Database.Models.PointOfInterest poi);
        Task<bool> DeletePointOfInterestAsync(Database.Models.PointOfInterest poi);
        Task<Database.Models.Role> GetRoleAsync(Database.Models.Role role);
        Task<bool> SetRoleAsync(Database.Models.Role role);
        Task<IEnumerable<Database.Models.User>> GetUsersAsync(Database.Models.User user);
        Task<Database.Models.User> GetUserAsync(Database.Models.User user);
        Task<Guid> AddUserAsync(Database.Models.User user);
        Task<bool> DeleteUserAsync(Database.Models.User user);
        Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync(Database.Models.SectorService sectorService);
        Task<Database.Models.SectorService> GetSectorAsync(Database.Models.SectorService sectorService);
        Task<Database.Models.SectorService> GetSectorServiceAsync(Database.Models.SectorService sectorService);
        Task<Guid> AddSectorServiceAsync(Database.Models.SectorService sectorService);
        Task<bool> DeleteSectorServiceAsync(Database.Models.SectorService sectorService);
        Task<Database.Models.Setting> GetSettingAsync(Database.Models.Setting setting);
        Task<Guid> CreateSettingsAsync(Database.Models.Setting setting);
        Task<bool> UpdateSettingsAsync(Database.Models.Setting setting);
    }
}
