using Dapper;
using SearchAndRescue.Configuration.Database.Models;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Configuration.Repositories
{
    public class Configuration : Contracts.Repositories.IConfiguration
    {
        private readonly IDbService _dbService;

        public Configuration(IDbService dbService) => _dbService = dbService;

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Category(), out string tableName, out string columns, out DynamicParameters parameters);
            var categories = await _dbService.ExecuteQueryAsync<Category>(Core.Database.Queries.Get(columns, tableName), parameters);

            return categories;
        }

        public async Task<IEnumerable<ContactType>> GetContactTypesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new ContactType(), out string tableName, out string columns, out DynamicParameters parameters);
            var contactTypes = await _dbService.ExecuteQueryAsync<ContactType>(Core.Database.Queries.Get(columns, tableName), parameters);

            return contactTypes;
        }

        public async Task<IEnumerable<EntityFavourites>> GetEntityFavouritesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new EntityFavourites(), out string tableName, out string columns, out DynamicParameters parameters);
            var entityFavourites = await _dbService.ExecuteQueryAsync<EntityFavourites>(Core.Database.Queries.Get(columns, tableName), parameters);

            return entityFavourites;
        }

        public async Task<IEnumerable<EntityType>> GetEntityTypesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new EntityType(), out string tableName, out string columns, out DynamicParameters parameters);
            var entityTypes = await _dbService.ExecuteQueryAsync<EntityType>(Core.Database.Queries.Get(columns, tableName), parameters);

            return entityTypes;
        }

        public async Task<IEnumerable<Feature>> GetFeaturesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Feature(), out string tableName, out string columns, out DynamicParameters parameters);
            var features = await _dbService.ExecuteQueryAsync<Feature>(Core.Database.Queries.Get(columns, tableName), parameters);

            return features;
        }

        public async Task<IEnumerable<Keyword>> GetKeywordsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Keyword(), out string tableName, out string columns, out DynamicParameters parameters);
            var keywords = await _dbService.ExecuteQueryAsync<Keyword>(Core.Database.Queries.Get(columns, tableName), parameters);

            return keywords;
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointOfInterestsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new PointOfInterest(), out string tableName, out string columns, out DynamicParameters parameters);
            var pois = await _dbService.ExecuteQueryAsync<PointOfInterest>(Core.Database.Queries.Get(columns, tableName), parameters);

            return pois;
        }

        public async Task<IEnumerable<ProductFavourites>> GetProductFavouritesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new ProductFavourites(), out string tableName, out string columns, out DynamicParameters parameters);
            var sectors = await _dbService.ExecuteQueryAsync<ProductFavourites>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectors;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Role(), out string tableName, out string columns, out DynamicParameters parameters);
            var roles = await _dbService.ExecuteQueryAsync<Role>(Core.Database.Queries.Get(columns, tableName), parameters);

            return roles;
        }

        public async Task<IEnumerable<Sector>> GetSectorsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Category(), out string tableName, out string columns, out DynamicParameters parameters);
            var sectors = await _dbService.ExecuteQueryAsync<Sector>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectors;
        }

        public async Task<IEnumerable<SectorService>> GetSectorServicesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new SectorService(), out string tableName, out string columns, out DynamicParameters parameters);
            var sectorServices = await _dbService.ExecuteQueryAsync<SectorService>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectorServices;
        }

        public async Task<IEnumerable<Service>> GetServicesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Service(), out string tableName, out string columns, out DynamicParameters parameters);
            var services = await _dbService.ExecuteQueryAsync<Service>(Core.Database.Queries.Get(columns, tableName), parameters);

            return services;
        }
    }
}
