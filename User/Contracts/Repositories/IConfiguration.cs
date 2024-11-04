using SearchAndRescue.User.Database.Models;

namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<Setting> GetSettingsAsync(Guid id);

        Task<bool> SetAsync(Guid id, Setting config);

        Task<IEnumerable<ContactType>> GetContactTypesAsync(Guid id);

        Task<IEnumerable<Database.Models.Entity>> GetEntitesAsync(Guid id);

        Task<IEnumerable<Favourite>> GetFavouritesAsync(Guid id);

        Task<IEnumerable<Feature>> GetFeaturesAsync(Guid id);

        Task<IEnumerable<Keyword>> GetKeywordsAsync(Guid id);

        Task<IEnumerable<PointOfInterest>> GetPointOfInterestsAsync(Guid id);

        Task<Role> GetRoleAsync(Guid id);

        Task<IEnumerable<SectorService>> GetSectorServicesAsync(Guid id);

        Task<IEnumerable<Database.Models.User>> GetUsersAsync(Guid id);
    }
}
