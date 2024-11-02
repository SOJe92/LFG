using IConfiguration = SearchAndRescue.User.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.User.Repositories
{
    public class Configuration : IConfiguration
    {
        public Configuration()
        {
        }

        public async Task<Database.Models.Configuration> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetAsync(Guid id, Database.Models.Configuration config)
        {
            throw new NotImplementedException();
        }
    }
}
