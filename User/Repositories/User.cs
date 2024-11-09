using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.User.Contracts.Repositories;
using SearchAndRescue.User.Database;
using SearchAndRescue.User.Database.Models;

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

        public async Task<Database.Models.User> GetByEmailAsync(Database.Models.User user)
        {
            string idCol = "email";
            PostgresDataAccess.BuildGetQuery(user, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            user = await _dbService.ExecuteQueryFirstAsync<Database.Models.User>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return user;
        }

        public async Task<Database.Models.User> GetAsync(Database.Models.User user)
        {
            string idCol = "id";
            PostgresDataAccess.BuildGetQuery(user, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            user = await _dbService.ExecuteQueryFirstAsync<Database.Models.User>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return user;
        }

        public async Task<Guid> AddAsync(Database.Models.User user)
        {
            PostgresDataAccess.BuildQuery(user, out string tableName, out string columns, out string parameters, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Core.Database.Queries.Insert(columns, tableName, parameters), parametersModel);
            return id;
        }

        public async Task<bool> DeleteAsync(Database.Models.User user)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", user.Id);
            PostgresDataAccess.BuildDeleteQuery(user, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<IEnumerable<Database.Models.Keyword>> GetKeywordsAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Keyword>(out string tableName, out string columns);
            IEnumerable<Database.Models.Keyword>? keywords = await _dbService.ExecuteQueryAsync<Database.Models.Keyword>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return keywords;
        }

        public async Task<Database.Models.Keyword> GetKeywordAsync(Database.Models.Keyword keyword)
        {
            string[] idCol = { "user_id", "keyword_id" };
            PostgresDataAccess.BuildGetQuery(keyword, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            keyword = await _dbService.ExecuteQueryFirstAsync<Database.Models.Keyword>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return keyword;
        }

        public async Task<Guid> AddKeywordAsync(Database.Models.Keyword keyword)
        {
            PostgresDataAccess.BuildParams(keyword, out DynamicParameters parametersModel);
            Guid result = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddKeyword, parametersModel);

            return result;
        }

        public async Task<bool> DeleteKeywordAsync(Database.Models.Keyword keyword)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", keyword.Id);
            PostgresDataAccess.BuildDeleteQuery(keyword, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<IEnumerable<Database.Models.ContactType>> GetContactTypesAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.ContactType>(out string tableName, out string columns);
            IEnumerable<Database.Models.ContactType>? contactTypes = await _dbService.ExecuteQueryAsync<Database.Models.ContactType>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return contactTypes;
        }

        public async Task<Guid> AddContactTypeAsync(Database.Models.ContactType contactType)
        {
            PostgresDataAccess.BuildParams(contactType, out DynamicParameters parametersModel);
            var contactTypeId = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddContactType, parametersModel);

            return contactTypeId;
        }

        public async Task<bool> DeleteContactTypeAsync(Database.Models.ContactType contactType)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", contactType.Id);
            PostgresDataAccess.BuildDeleteQuery(contactType, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<IEnumerable<Database.Models.Entity>> GetEntitiesAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Entity>(out string tableName, out string columns);
            IEnumerable<Database.Models.Entity>? entities = await _dbService.ExecuteQueryAsync<Database.Models.Entity>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return entities;
        }

        public async Task<Database.Models.Entity> GetEntityAsync(Database.Models.Entity entity)
        {
            string[] idCol = { "user_id", "entity_id" };
            PostgresDataAccess.BuildGetQuery(entity, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            entity = await _dbService.ExecuteQueryFirstAsync<Database.Models.Entity>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return entity;
        }

        public async Task<Guid> AddEntityAsync(Database.Models.Entity entity)
        {
            PostgresDataAccess.BuildParams(entity, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddEntity, parametersModel);

            return id;
        }

        public async Task<bool> DeleteEntityAsync(Database.Models.Entity entity)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"pid", entity.Id);
            paramModel.Add($"pentityid", entity.EntityId);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.DeleteEntity, paramModel);

            return success;
        }

        public async Task<Database.Models.Favourite> GetFavouriteAsync(Database.Models.Favourite favourite)
        {
            string[] idCol = { "user_id", "favourite_id" };
            PostgresDataAccess.BuildGetQuery(favourite, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            favourite = await _dbService.ExecuteQueryFirstAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favourite;
        }

        public async Task<IEnumerable<Database.Models.Favourite>> GetFavouritesAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Favourite>(out string tableName, out string columns);
            IEnumerable<Database.Models.Favourite>? favourites = await _dbService.ExecuteQueryAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return favourites;
        }

        public async Task<Guid> AddFavouriteAsync(Database.Models.Favourite favourite)
        {
            PostgresDataAccess.BuildParams(favourite, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddFavourite, parametersModel);

            return id;
        }

        public async Task<bool> DeleteFavouriteAsync(Database.Models.Favourite favourite)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"pid", favourite.Id);
            paramModel.Add($"pfavouriteid", favourite.FavouriteId);
            paramModel.Add($"ptypeid", favourite.TypeId);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.DeleteFavourite, paramModel);

            return success;
        }

        public async Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Feature>(out string tableName, out string columns);
            IEnumerable<Database.Models.Feature>? features = await _dbService.ExecuteQueryAsync<Database.Models.Feature>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return features;
        }

        public async Task<Database.Models.Feature> GetFeatureAsync(Database.Models.Feature feature)
        {
            string[] idCol = { "user_id", "feature_id" };
            PostgresDataAccess.BuildGetQuery(feature, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            feature = await _dbService.ExecuteQueryFirstAsync<Database.Models.Feature>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return feature;
        }

        public async Task<bool> UpdateFeatureAsync(Database.Models.Feature feature)
        {
            string[] idCol = { "user_id", "feature_id" };
            PostgresDataAccess.BuildUpdateQuery(feature, out string tableName, out string columns);
            var success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.UpdateById(columns, tableName, idCol), feature);

            return success;
        }

        public async Task<Database.Models.PointOfInterest> GetPointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            string[] idCol = { "user_id", "poi_id" };
            PostgresDataAccess.BuildGetQuery(poi, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            poi = await _dbService.ExecuteQueryFirstAsync<Database.Models.PointOfInterest>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return poi;
        }

        public async Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.PointOfInterest>(out string tableName, out string columns);
            IEnumerable<Database.Models.PointOfInterest>? pois = await _dbService.ExecuteQueryAsync<Database.Models.PointOfInterest>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return pois;
        }

        public async Task<Guid> AddPointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            PostgresDataAccess.BuildParams(poi, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddPOI, parametersModel);

            return id;
        }

        public async Task<bool> DeletePointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"pid", poi.Id);
            paramModel.Add($"ppoid", poi.PointOfInterestId);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.DeletePOI, paramModel);

            return success;
        }

        public async Task<Database.Models.Role> GetRoleAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Role>(out string tableName, out string columns);
            Database.Models.Role role = await _dbService.ExecuteQueryFirstAsync<Database.Models.Role>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return role;
        }

        public async Task<bool> SetRoleAsync(Database.Models.Role role)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"puserid", role.UserId);
            var success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.UpdateRole, paramModel);

            return success;
        }

        public async Task<IEnumerable<Database.Models.ChildUser>> GetUsersAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.ChildUser>(out string tableName, out string columns);
            IEnumerable<Database.Models.ChildUser>? users = await _dbService.ExecuteQueryAsync<Database.Models.ChildUser>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return users;
        }

        public async Task<Database.Models.ChildUser> GetUserAsync(Database.Models.ChildUser user)
        {
            string[] idCol = { "user_id", "child_user_id" };
            PostgresDataAccess.BuildGetQuery(user, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            user = await _dbService.ExecuteQueryFirstAsync<Database.Models.ChildUser>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return user;
        }

        public async Task<Guid> AddUserAsync(Database.Models.ChildUser user)
        {
            PostgresDataAccess.BuildParams(user, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddUser, parametersModel);

            return id;
        }

        public async Task<bool> DeleteUserAsync(Database.Models.ChildUser user)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", user.Id);
            PostgresDataAccess.BuildDeleteQuery(user, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.SectorService>(out string tableName, out string columns);
            IEnumerable<Database.Models.SectorService>? sectorServices = await _dbService.ExecuteQueryAsync<Database.Models.SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return sectorServices;
        }

        public async Task<Database.Models.SectorService> GetSectorAsync(Database.Models.SectorService sectorService)
        {
            string[] idCol = { "user_id", "sector_id" };
            PostgresDataAccess.BuildGetQuery(sectorService, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            sectorService = await _dbService.ExecuteQueryFirstAsync<SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return sectorService;
        }

        public async Task<SectorService> GetSectorServiceAsync(SectorService sectorService)
        {
            string[] idCol = { "user_id", "sector_id", "service_id" };
            PostgresDataAccess.BuildGetQuery(sectorService, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            sectorService = await _dbService.ExecuteQueryFirstAsync<SectorService>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return sectorService;
        }

        public async Task<Guid> AddSectorServiceAsync(SectorService sectorService)
        {
            PostgresDataAccess.BuildParams(sectorService, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddSectorService, parametersModel);

            return id;
        }

        public async Task<bool> DeleteSectorServiceAsync(SectorService sectorService)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", sectorService.Id);
            PostgresDataAccess.BuildDeleteQuery(sectorService, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<Setting> GetSettingsAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", userId);
            PostgresDataAccess.BuildGetQuery<Setting>(out string tableName, out string columns);
            Setting setting = await _dbService.ExecuteQueryFirstAsync<Database.Models.Setting>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return setting;
        }

        public async Task<Guid> CreateSettingsAsync(Setting setting)
        {

            PostgresDataAccess.BuildParams(setting, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.CreateSetting, parametersModel);
            return id;
        }

        public async Task<bool> UpdateSettingsAsync(Setting setting)
        {
            string[] idCol = { "user_id", "feature_id" };
            PostgresDataAccess.BuildUpdateQuery(setting, out string tableName, out string columns);
            var success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.UpdateById(columns, tableName, idCol), setting);

            return success;
        }

        public async Task<IEnumerable<Database.Models.Product>> GetProductsAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Database.Models.Product> GetProductAsync(Database.Models.Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> AddProductAsync(Database.Models.Product product)
        {
            PostgresDataAccess.BuildParams(product, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddProduct, parametersModel);

            return id;
        }

        public async Task<bool> DeleteProductAsync(Database.Models.Product product)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"pid", product.Id);
            paramModel.Add($"pproductid", product.ProductId);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.DeleteProduct, paramModel);

            return success;
        }

        public async Task<Guid> AddFavouriteEntityAsync(Database.Models.Favourite favourite)
        {
            PostgresDataAccess.BuildParams(favourite, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddFavouriteEntity, parametersModel);

            return id;
        }

        public async Task<Guid> AddFavouriteProductAsync(Database.Models.Favourite favourite)
        {
            PostgresDataAccess.BuildParams(favourite, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Queries.AddFavouriteProduct, parametersModel);

            return id;
        }

        public async Task<bool> DeleteFavouriteEntityAsync(Database.Models.Favourite favourite)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"pid", favourite.Id);
            paramModel.Add($"pfavouriteid", favourite.FavouriteId);
            paramModel.Add($"ptypeid", favourite.TypeId);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.DeleteFavouriteEntity, paramModel);

            return success;
        }

        public async Task<bool> DeleteFavouriteProductAsync(Database.Models.Favourite favourite)
        {
            DynamicParameters paramModel = new();
            paramModel.Add($"pid", favourite.Id);
            paramModel.Add($"pfavouriteid", favourite.FavouriteId);
            paramModel.Add($"ptypeid", favourite.TypeId);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Queries.DeleteFavouriteProduct, paramModel);

            return success;
        }

        public async Task<Database.Models.Favourite> GetFavouriteProductAsync(Database.Models.Favourite favourite)
        {
            string[] idCol = { "user_id", "favourite_id" };
            PostgresDataAccess.BuildGetQuery(favourite, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            favourite = await _dbService.ExecuteQueryFirstAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favourite;
        }

        public async Task<Database.Models.Favourite> GetFavouriteEntityAsync(Database.Models.Favourite favourite)
        {
            string[] idCol = { "user_id", "favourite_id" };
            PostgresDataAccess.BuildGetQuery(favourite, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            favourite = await _dbService.ExecuteQueryFirstAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favourite;
        }

        public async Task<IEnumerable<Database.Models.Favourite>> GetFavouriteProductsAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"puserid", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Favourite>(out string tableName, out string columns);
            IEnumerable<Database.Models.Favourite>? favourites = await _dbService.ExecuteQueryAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return favourites;
        }

        public async Task<IEnumerable<Database.Models.Favourite>> GetFavouriteEntitiesAsync(Guid userId)
        {
            string idCol = "user_id";
            DynamicParameters paramModel = new();
            paramModel.Add($"puserid", userId);
            PostgresDataAccess.BuildGetQuery<Database.Models.Favourite>(out string tableName, out string columns);
            IEnumerable<Database.Models.Favourite>? favourites = await _dbService.ExecuteQueryAsync<Database.Models.Favourite>(Core.Database.Queries.GetById(columns, tableName, idCol), paramModel);

            return favourites;
        }
    }
}
