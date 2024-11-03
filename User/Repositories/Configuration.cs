using IConfiguration = SearchAndRescue.User.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.User.Repositories
{
    public class Configuration : IConfiguration
    {
        public Configuration()
        {
        }

        public async Task<Database.Models.Setting> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetAsync(Guid id, Database.Models.Setting config)
        {
            throw new NotImplementedException();
        }
    }
}
