namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IUser
    {
        Task<Database.Models.User> GetAsync(Database.Models.User user);
        Task<Database.Models.User> GetByEmailAsync(Database.Models.User user);
        Task<Guid> AddAsync(Database.Models.User user);
        Task<bool> DeleteAsync(Database.Models.User user);
        Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync(Guid userId);
        Task<Database.Models.Keyword> GetKeywordAsync(Database.Models.Keyword keyword);
        Task<Guid> AddKeywordAsync(Database.Models.Keyword keyword);
        Task<bool> DeleteKeywordAsync(Database.Models.Keyword keyword);
        Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync(Guid userId);
        Task<Guid> AddContactTypeAsync(Database.Models.ContactType contactType);
        Task<bool> DeleteContactTypeAsync(Database.Models.ContactType contactType);
        Task<IEnumerable<Database.Models.Entity>> GetEntitiesAsync(Guid userId);
        Task<Database.Models.Entity> GetEntityAsync(Database.Models.Entity entity);
        Task<Guid> AddEntityAsync(Database.Models.Entity entity);
        Task<bool> DeleteEntityAsync(Database.Models.Entity entity);
        Task<IEnumerable<Database.Models.Product>> GetProductsAsync(Guid userId);
        Task<Database.Models.Product> GetProductAsync(Database.Models.Product product);
        Task<Guid> AddProductAsync(Database.Models.Product product);
        Task<bool> DeleteProductAsync(Database.Models.Product product);
        Task<Database.Models.Favourite> GetFavouriteAsync(Database.Models.Favourite favourite);
        Task<IEnumerable<Database.Models.Favourite>> GetFavouritesAsync(Guid userId);
        Task<Guid> AddFavouriteAsync(Database.Models.Favourite favourite);
        Task<bool> DeleteFavouriteAsync(Database.Models.Favourite favourite);
        Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync(Guid userId);
        Task<Database.Models.Feature> GetFeatureAsync(Database.Models.Feature feature);
        Task<bool> UpdateFeatureAsync(Database.Models.Feature feature);
        Task<Database.Models.PointOfInterest> GetPointOfInterestAsync(Database.Models.PointOfInterest poi);
        Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync(Guid userId);
        Task<Guid> AddPointOfInterestAsync(Database.Models.PointOfInterest poi);
        Task<bool> DeletePointOfInterestAsync(Database.Models.PointOfInterest poi);
        Task<Database.Models.Role> GetRoleAsync(Guid userId);
        Task<bool> SetRoleAsync(Database.Models.Role role);
        Task<IEnumerable<Database.Models.ChildUser>> GetUsersAsync(Guid userId);
        Task<Database.Models.ChildUser> GetUserAsync(Database.Models.ChildUser user);
        Task<Guid> AddUserAsync(Database.Models.ChildUser user);
        Task<bool> DeleteUserAsync(Database.Models.ChildUser user);
        Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync(Guid userId);
        Task<Database.Models.SectorService> GetSectorAsync(Database.Models.SectorService sectorService);
        Task<Database.Models.SectorService> GetSectorServiceAsync(Database.Models.SectorService sectorService);
        Task<Guid> AddSectorServiceAsync(Database.Models.SectorService sectorService);
        Task<bool> DeleteSectorServiceAsync(Database.Models.SectorService sectorService);
        Task<Database.Models.Setting> GetSettingsAsync(Guid userId);
        Task<Guid> CreateSettingsAsync(Database.Models.Setting setting);
        Task<bool> UpdateSettingsAsync(Database.Models.Setting setting);
    }
}
