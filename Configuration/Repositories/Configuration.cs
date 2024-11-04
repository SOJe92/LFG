using SearchAndRescue.Configuration.Database;
using SearchAndRescue.Configuration.Database.Models;
using SearchAndRescue.Core.Database.Contracts;

namespace SearchAndRescue.Configuration.Repositories
{
    public class Configuration : Contracts.Repositories.IConfiguration
    {
        private readonly IDbService _dbService;

        public Configuration(IDbService dbService) => _dbService = dbService;

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var categories = await _dbService.ExecuteQueryAsync<Category>(Queries.GetCategories);

            return categories;
        }

        public async Task<IEnumerable<ContactType>> GetContactTypesAsync()
        {
            var contactTypes = await _dbService.ExecuteQueryAsync<ContactType>(Queries.GetContactTypes);

            return contactTypes;
        }

        public async Task<IEnumerable<EntityFavourites>> GetEntityFavouritesAsync()
        {
            var entityFavourites = await _dbService.ExecuteQueryAsync<EntityFavourites>(Queries.GetEntityFavourites);

            return entityFavourites;
        }

        public async Task<IEnumerable<EntityType>> GetEntityTypesAsync()
        {
            var entityTypes = await _dbService.ExecuteQueryAsync<EntityType>(Queries.GetEntityTypes);

            return entityTypes;
        }

        public async Task<IEnumerable<Feature>> GetFeaturesAsync()
        {
            var features = await _dbService.ExecuteQueryAsync<Feature>(Queries.GetFeatures);

            return features;
        }

        public async Task<IEnumerable<Keyword>> GetKeywordsAsync()
        {
            var keywords = await _dbService.ExecuteQueryAsync<Keyword>(Queries.GetKeywords);

            return keywords;
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointOfInterestsAsync()
        {
            var pois = await _dbService.ExecuteQueryAsync<PointOfInterest>(Queries.GetPointOfInterests);

            return pois;
        }

        public async Task<IEnumerable<ProductFavourites>> GetProductFavouritesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<ProductFavourites>(Queries.GetProductFavourites);

            return sectors;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            var roles = await _dbService.ExecuteQueryAsync<Role>(Queries.GetRoles);

            return roles;
        }

        public async Task<IEnumerable<Sector>> GetSectorsAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public async Task<IEnumerable<SectorService>> GetSectorServicesAsync()
        {
            var sectorServices = await _dbService.ExecuteQueryAsync<SectorService>(Queries.GetSectorServices);

            return sectorServices;
        }

        public async Task<IEnumerable<Service>> GetServicesAsync()
        {
            var services = await _dbService.ExecuteQueryAsync<Service>(Queries.GetServices);

            return services;
        }
    }
}
