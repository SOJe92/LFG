using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Favourite.Contracts.Repositories;
using SearchAndRescue.Favourite.Database.Models;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Favourite.Repositories
{
    public class Favourite : IFavourite
    {
        private readonly IDbService _dbService;

        public Favourite(IDbService dbService) => _dbService = dbService;

        public async Task<Guid> AddEntityFavouriteAsync(UserFavourite entityFavourite)
        {
            PostgresDataAccess.BuildQuery(entityFavourite, out string tableName, out string columns, out string parameters, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Core.Database.Queries.Insert(columns, tableName, parameters), parametersModel);
            return id;
        }

        public async Task<Guid> AddProductFavouriteAsync(UserFavourite productFavourite)
        {
            PostgresDataAccess.BuildQuery(productFavourite, out string tableName, out string columns, out string parameters, out DynamicParameters parametersModel);
            Guid id = await _dbService.ExecuteQueryFirstAsync<Guid>(Core.Database.Queries.Insert(columns, tableName, parameters), parametersModel);
            return id;
        }

        public async Task<bool> DeleteEntityFavouriteAsync(UserFavourite entityFavourite)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", entityFavourite.Id);
            PostgresDataAccess.BuildDeleteQuery(entityFavourite, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<bool> DeleteProductFavouriteAsync(UserFavourite productFavourite)
        {
            string idCol = "id";
            DynamicParameters paramModel = new();
            paramModel.Add($"p{idCol.Replace("_", "")}", productFavourite.Id);
            PostgresDataAccess.BuildDeleteQuery(productFavourite, out string tableName);
            bool success = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.DeleteById(tableName, idCol), paramModel);

            return success;
        }

        public async Task<EntityFavourite> GetEntityFavouriteAsync(EntityFavourite entityFavourite)
        {
            string idCol = "id";
            PostgresDataAccess.BuildGetQuery(entityFavourite, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            entityFavourite = await _dbService.ExecuteQueryFirstAsync<Database.Models.EntityFavourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return entityFavourite;
        }

        public async Task<IEnumerable<EntityFavourite>> GetEntityFavouritesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new EntityFavourite(), out string tableName, out string columns, out DynamicParameters parameters);
            var entityFavourites = await _dbService.ExecuteQueryAsync<EntityFavourite>(Core.Database.Queries.Get(columns, tableName), parameters);

            return entityFavourites;
        }

        public Task<IEnumerable<EntityFavourite>> GetEntityFavouritesAsync(EntityFavourite entityFavourite)
        {
            throw new NotImplementedException();
        }

        public async Task<FavouriteType> GetFavouriteTypeAsync(FavouriteType favouriteType)
        {
            string idCol = "id";
            PostgresDataAccess.BuildGetQuery(favouriteType, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            favouriteType = await _dbService.ExecuteQueryFirstAsync<Database.Models.FavouriteType>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return favouriteType;
        }

        public async Task<IEnumerable<FavouriteType>> GetFavouriteTypesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new FavouriteType(), out string tableName, out string columns, out DynamicParameters parameters);
            var favouriteTypes = await _dbService.ExecuteQueryAsync<FavouriteType>(Core.Database.Queries.Get(columns, tableName), parameters);

            return favouriteTypes;
        }

        public async Task<ProductFavourite> GetProductFavouriteAsync(ProductFavourite productFavourite)
        {
            string idCol = "id";
            PostgresDataAccess.BuildGetQuery(productFavourite, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            productFavourite = await _dbService.ExecuteQueryFirstAsync<Database.Models.ProductFavourite>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return productFavourite;
        }

        public async Task<IEnumerable<ProductFavourite>> GetProductFavouritesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new ProductFavourite(), out string tableName, out string columns, out DynamicParameters parameters);
            var sectors = await _dbService.ExecuteQueryAsync<ProductFavourite>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectors;
        }

        public Task<IEnumerable<ProductFavourite>> GetProductFavouritesAsync(ProductFavourite productFavourite)
        {
            throw new NotImplementedException();
        }
    }
}
