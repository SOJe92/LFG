using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.User.Database.Models;
using IConfiguration = SearchAndRescue.User.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.User.Repositories
{
    public class Configuration : IConfiguration
    {
        private readonly IDbService _dbService;

        public Configuration(IDbService dbService) => _dbService = dbService;

        public async Task<Setting> GetSettingsAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Setting(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var settings = await _dbService.ExecuteQueryAsync<Setting>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return settings.First();
        }

        public async Task<bool> SetAsync(Guid id, Setting config)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContactType>> GetContactTypesAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new ContactType(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var contactTypes = await _dbService.ExecuteQueryAsync<ContactType>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return contactTypes;
        }

        public async Task<IEnumerable<Database.Models.Entity>> GetEntitesAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.Entity(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var entities = await _dbService.ExecuteQueryAsync<Database.Models.Entity>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return entities;
        }

        public async Task<IEnumerable<Favourite>> GetFavouritesAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Favourite(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var favourites = await _dbService.ExecuteQueryAsync<Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favourites;
        }

        public async Task<IEnumerable<Feature>> GetFeaturesAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Feature(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var features = await _dbService.ExecuteQueryAsync<Feature>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return features;
        }

        public async Task<IEnumerable<Keyword>> GetKeywordsAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Keyword(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var keywords = await _dbService.ExecuteQueryAsync<Keyword>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return keywords;
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointOfInterestsAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new PointOfInterest(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var pois = await _dbService.ExecuteQueryAsync<PointOfInterest>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return pois;
        }

        public async Task<Role> GetRoleAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Role(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var roles = await _dbService.ExecuteQueryAsync<Role>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return roles.First();
        }

        public async Task<IEnumerable<SectorService>> GetSectorServicesAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new SectorService(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var sectorServices = await _dbService.ExecuteQueryAsync<SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return sectorServices;
        }

        public async Task<IEnumerable<Database.Models.User>> GetUsersAsync(Guid id)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.User(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            var users = await _dbService.ExecuteQueryAsync<Database.Models.User>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return users;
        }
    }
}
