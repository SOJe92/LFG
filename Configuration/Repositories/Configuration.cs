using SearchAndRescue.Configuration.Database;
using SearchAndRescue.Configuration.Database.Models;
using SearchAndRescue.Core.Database.Contracts;

namespace SearchAndRescue.Configuration.Repositories
{
    public class Configuration : Contracts.Repositories.IConfiguration
    {
        private readonly IDbService _dbService;

        public Configuration(IDbService dbService) => _dbService = dbService;

        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var categories = await _dbService.ExecuteQueryAsync<Category>(Queries.GetCategories);

            return categories;
        }

        public Task<IEnumerable<ContactType>> GetContactTypesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<EntityFavourites>> GetEntityFavouritesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<EntityType>> GetEntityTypesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<Feature>> GetFeaturesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<Keyword>> GetKeywordsAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<PointOfInterest>> GetPointOfInterestsAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<ProductFavourites>> GetProductFavouritesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<Role>> GetRolesAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public async Task<IEnumerable<Sector>> GetSectorsAsync()
        {
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Queries.GetSectors);

            return sectors;
        }

        public Task<IEnumerable<Service>> GetServicesAsync()
        {
            var services = await _dbService.ExecuteQueryAsync<Service>(Queries.GetServices);

            return services;
        }
    }
}
