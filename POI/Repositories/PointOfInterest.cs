using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.POI.Contracts.Repositories;

namespace SearchAndRescue.POI.Repositories
{
    public class PointOfInterest : IPointOfInterest
    {
        private readonly IDbService _dbService;

        public PointOfInterest(IDbService dbService) => _dbService = dbService;
        public async Task<Database.Models.PointOfInterest> GetPointOfInterestAsync(Database.Models.PointOfInterest poi)
        {
            PostgresDataAccess.BuildGetQuery(poi, out string tableName, out string columns, out DynamicParameters parameters, "id");
            poi = await _dbService.ExecuteQueryFirstAsync<Database.Models.PointOfInterest>(Core.Database.Queries.Get(columns, tableName), parameters);

            return poi;
        }

        public async Task<IEnumerable<Database.Models.PointOfInterest>> GetPointOfInterestsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.PointOfInterest(), out string tableName, out string columns, out DynamicParameters parameters);
            var pois = await _dbService.ExecuteQueryAsync<Database.Models.PointOfInterest>(Core.Database.Queries.Get(columns, tableName), parameters);

            return pois;
        }
    }
}
