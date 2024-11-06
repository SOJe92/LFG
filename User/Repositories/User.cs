using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.User.Contracts.Repositories;
using SearchAndRescue.User.Database;

namespace SearchAndRescue.User.Repositories
{
    public class User : IUser
    {
        private readonly IDbService _dbService;

        public User(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<Database.Models.User> TryGet(Database.Models.User login)
        {
            PostgresDataAccess.BuildParams(login, out DynamicParameters parameters);
            DynamicParameters? result = await _dbService.ExecuteProcedureAsync(Queries.TrySignin, parameters);
            login.Id = result.Get<Guid>("id");

            return login;
        }

        public async Task<Database.Models.User> Get(Database.Models.User login)
        {
            PostgresDataAccess.BuildQuery<Database.Models.User>(out string tableName, out string columnNames);
            string query = $"SELECT {columnNames} FROM {tableName}",
                    filter = $"WHERE password=@password AND {(login.Username != null ? "username=@username" : "email=@email")}";

            Database.Models.User? result = await _dbService.GetAsync<Database.Models.User>($"{query} {filter}", login);

            return result;
        }

        public async Task<Database.Models.User> GetAsync(Database.Models.User user)
        {
            string idCol = "id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.User(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.User>? users = await _dbService.ExecuteQueryAsync<Database.Models.User>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return users.First();
        }

        public async Task<Guid> AddAsync(Database.Models.User user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Database.Models.User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.Keyword(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Keyword>? keywords = await _dbService.ExecuteQueryAsync<Database.Models.Keyword>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return keywords;
        }

        public async Task<Database.Models.Keyword> GetKeywordAsync(Database.Models.Keyword keyword)
        {
            string[] idCol = { "user_id", "keyword_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.Keyword(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Keyword>? keywords = await _dbService.ExecuteQueryAsync<Database.Models.Keyword>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return keywords.First();
        }

        public async Task<Guid> AddKeywordAsync(Database.Models.Keyword keyword)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteKeywordAsync(Database.Models.Keyword keyword)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.ContactType(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.ContactType>? contactTypes = await _dbService.ExecuteQueryAsync<Database.Models.ContactType>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return contactTypes;
        }

        public async Task<Guid> AddContactTypeAsync(Database.Models.ContactType contactType)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteContactTypeAsync(Database.Models.ContactType contactType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.Entity>> GetEntitiesAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.Entity(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Entity>? entities = await _dbService.ExecuteQueryAsync<Database.Models.Entity>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return entities;
        }

        public async Task<Database.Models.Entity> GetEntityAsync(Database.Models.Entity entity)
        {
            string[] idCol = { "user_id", "entity_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.Entity(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Entity>? entities = await _dbService.ExecuteQueryAsync<Database.Models.Entity>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return entities.First();
        }

        public async Task<Guid> AddEntityAsync(Database.Models.Entity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteEntityAsync(Database.Models.Entity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Database.Models.Favourite> GetFavouriteAsync(Database.Models.Favourite favouritw)
        {
            string[] idCol = { "user_id", "favourite_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.Favourite(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Favourite>? favourites = await _dbService.ExecuteQueryAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favourites.First();
        }

        public async Task<IEnumerable<Database.Models.Favourite>> GetFavouritesAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.Favourite(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Favourite>? favourites = await _dbService.ExecuteQueryAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favourites;
        }

        public async Task<Guid> AddFavouriteAsync(Database.Models.Favourite favourite)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteFavouriteAsync(Database.Models.Favourite favouritw)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.Feature(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Feature>? features = await _dbService.ExecuteQueryAsync<Database.Models.Feature>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return features;
        }

        public async Task<Database.Models.Feature> GetFeatureAsync(Database.Models.Feature feature)
        {
            string[] idCol = { "user_id", "feature_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.Feature(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Feature>? features = await _dbService.ExecuteQueryAsync<Database.Models.Feature>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return features.First();
        }

        public async Task<Guid> UpdateFeatureAsync(Database.Models.Feature feature)
        {
            throw new NotImplementedException();
        }

        public async Task<Database.Models.PointOfInterest> GetPointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            string[] idCol = { "user_id", "poi_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.PointOfInterest(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.PointOfInterest>? pois = await _dbService.ExecuteQueryAsync<Database.Models.PointOfInterest>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return pois.First();
        }

        public async Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.PointOfInterest(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.PointOfInterest>? pois = await _dbService.ExecuteQueryAsync<Database.Models.PointOfInterest>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return pois;
        }

        public async Task<Guid> AddPointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            throw new NotImplementedException();
        }

        public async Task<Database.Models.Role> GetRoleAsync(Guid userId)
        {
            string[] idCol = { "user_id", "role_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.Role(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Role>? roles = await _dbService.ExecuteQueryAsync<Database.Models.Role>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return roles.First();
        }

        public async Task<bool> SetRoleAsync(Database.Models.Role role)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.ChildUser>> GetUsersAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.ChildUser(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.ChildUser>? users = await _dbService.ExecuteQueryAsync<Database.Models.ChildUser>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return users;
        }

        public async Task<Database.Models.ChildUser> GetUserAsync(Database.Models.ChildUser user)
        {
            string[] idCol = { "user_id", "child_user_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.ChildUser(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.ChildUser>? users = await _dbService.ExecuteQueryAsync<Database.Models.ChildUser>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return users.First();
        }

        public async Task<Guid> AddUserAsync(Database.Models.ChildUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteUserAsync(Database.Models.ChildUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync(Guid userId)
        {
            string idCol = "user_id";
            PostgresDataAccess.BuildGetQuery(new Database.Models.SectorService(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.SectorService>? sectorServices = await _dbService.ExecuteQueryAsync<Database.Models.SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return sectorServices;
        }

        public async Task<Database.Models.SectorService> GetSectorAsync(Database.Models.SectorService sectorService)
        {
            string[] idCol = { "user_id", "sector_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.SectorService(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.SectorService>? sectorServices = await _dbService.ExecuteQueryAsync<Database.Models.SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return sectorServices.First();
        }

        public async Task<Database.Models.SectorService> GetSectorServiceAsync(Database.Models.SectorService sectorService)
        {
            string[] idCol = { "user_id", "sector_id", "service_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.SectorService(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.SectorService>? sectorServices = await _dbService.ExecuteQueryAsync<Database.Models.SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return sectorServices.First();
        }

        public async Task<Guid> AddSectorServiceAsync(Database.Models.SectorService sectorService)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteSectorServiceAsync(Database.Models.SectorService sectorService)
        {
            throw new NotImplementedException();
        }

        public async Task<Database.Models.Setting> GetSettingsAsync(Guid id)
        {
            string[] idCol = { "user_id", "setting_id" };
            PostgresDataAccess.BuildGetQuery(new Database.Models.Setting(), out string tableName, out string columns, out DynamicParameters parameters, idCol);
            IEnumerable<Database.Models.Setting>? settings = await _dbService.ExecuteQueryAsync<Database.Models.Setting>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return settings.First();
        }

        public async Task<Guid> CreateSettingsAsync(Database.Models.Setting setting)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateSettingsAsync(Database.Models.Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}
