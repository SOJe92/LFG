namespace SearchAndRescue.Configuration.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<IEnumerable<Database.Models.Sector>> GetSectorsAsync();
        Task<IEnumerable<Database.Models.Category>> GetCategoriesAsync();
        Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync();
        Task<IEnumerable<Database.Models.EntityFavourites>> GetEntityFavouritesAsync();
        Task<IEnumerable<Database.Models.EntityType>> GetEntityTypesAsync();
        Task<IEnumerable<Database.Models.FavouriteType>> GetFavouriteTypesAsync();
        Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync();
        Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync();
        Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync();
        Task<IEnumerable<Database.Models.ProductFavourites>> GetProductFavouritesAsync();
        Task<IEnumerable<Database.Models.Role>> GetRolesAsync();
        Task<IEnumerable<Database.Models.Service>> GetServicesAsync();
        Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync();
    }
}
