using SearchAndRescue.Configuration.Database;
using SearchAndRescue.Configuration.Models;
using SearchAndRescue.Core.Database.Contracts;

namespace SearchAndRescue.Configuration.Repositories
{
    public class Configuration : Contracts.Repositories.IConfiguration
    {
        private readonly IDbService _dbService;

        public Configuration(IDbService dbService) => _dbService = dbService;

        public async Task<IEnumerable<Sector>> GetSectorsAsync()
        {
            var sectors = await _dbService.ExecuteFunctionAsync<Sector>(Queries.GetSectors);

            return sectors;
        }
    }
}
