using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.Sectors.Contracts.Repositories;
using SearchAndRescue.Sectors.Database.Models;

namespace SearchAndRescue.Sectors.Repositories
{
    public class Sector : ISector
    {
        private readonly IDbService _dbService;

        public Sector(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<Database.Models.Sector> GetSectorAsync(Database.Models.Sector sector)
        {
            PostgresDataAccess.BuildGetQuery(sector, out string tableName, out string columns, out DynamicParameters parameters, "id");
            sector = await _dbService.ExecuteQueryFirstAsync<Database.Models.Sector>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sector;
        }

        public async Task<IEnumerable<Database.Models.Sector>> GetSectorsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Sector(), out string tableName, out string columns, out DynamicParameters parameters);
            IEnumerable<Database.Models.Sector>? sectors = await _dbService.ExecuteQueryAsync<Database.Models.Sector>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectors;
        }

        public async Task<Database.Models.SectorService> GetSectorServiceAsync(Database.Models.SectorService sectorService)
        {
            PostgresDataAccess.BuildGetQuery(sectorService, out string tableName, out string columns, out DynamicParameters parameters, "id");
            sectorService = await _dbService.ExecuteQueryFirstAsync<Database.Models.SectorService>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectorService;
        }

        public async Task<IEnumerable<Database.Models.SectorService>> GetSectorServicesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.SectorService(), out string tableName, out string columns, out DynamicParameters parameters);
            IEnumerable<SectorService>? sectorServices = await _dbService.ExecuteQueryAsync<Database.Models.SectorService>(Core.Database.Queries.Get(columns, tableName), parameters);

            return sectorServices;
        }

        public async Task<Database.Models.Service> GetServiceAsync(Database.Models.Service service)
        {
            PostgresDataAccess.BuildGetQuery(service, out string tableName, out string columns, out DynamicParameters parameters, "id");
            service = await _dbService.ExecuteQueryFirstAsync<Database.Models.Service>(Core.Database.Queries.Get(columns, tableName), parameters);

            return service;
        }

        public async Task<IEnumerable<Database.Models.Service>> GetServicesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Service(), out string tableName, out string columns, out DynamicParameters parameters);
            IEnumerable<Service>? services = await _dbService.ExecuteQueryAsync<Database.Models.Service>(Core.Database.Queries.Get(columns, tableName), parameters);

            return services;
        }
    }
}
