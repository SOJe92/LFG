using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Feature.Contracts.Repositories;
using SearchAndRescue.Feature.Database.Models;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Feature.Repositories
{
    public class Feature : IFeature
    {
        private readonly IDbService _dbService;

        public Feature(IDbService dbService) => _dbService = dbService;

        public async Task<Database.Models.Feature> GetFeatureAsync(Database.Models.Feature feature)
        {
            PostgresDataAccess.BuildGetQuery(feature, out string tableName, out string columns, out DynamicParameters parameters, "id");
            feature = await _dbService.ExecuteQueryFirstAsync<Database.Models.Feature>(Core.Database.Queries.Get(columns, tableName), parameters);

            return feature;
        }

        public async Task<FeaturePermission> GetFeaturePermissionAsync(FeaturePermission feature)
        {
            PostgresDataAccess.BuildGetQuery(feature, out string tableName, out string columns, out DynamicParameters parameters, "id");
            feature = await _dbService.ExecuteQueryFirstAsync<Database.Models.FeaturePermission>(Core.Database.Queries.Get(columns, tableName), parameters);

            return feature;
        }

        public async Task<IEnumerable<FeaturePermission>> GetFeaturePermissionsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.FeaturePermission(), out string tableName, out string columns, out DynamicParameters parameters);
            var features = await _dbService.ExecuteQueryAsync<Database.Models.FeaturePermission>(Core.Database.Queries.Get(columns, tableName), parameters);

            return features;
        }

        public async Task<IEnumerable<Database.Models.Feature>> GetFeaturesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Feature(), out string tableName, out string columns, out DynamicParameters parameters);
            var features = await _dbService.ExecuteQueryAsync<Database.Models.Feature>(Core.Database.Queries.Get(columns, tableName), parameters);

            return features;
        }
    }
}
