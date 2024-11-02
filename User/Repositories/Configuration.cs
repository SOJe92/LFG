using IConfiguration = SearchAndRescue.User.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.User.Repositories
{
    public class Configuration : IConfiguration
    {
        public Configuration()
        {
        }

        public async Task<Models.Configuration> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetAsync(Guid id, Models.Configuration config)
        {
            throw new NotImplementedException();
        }
    }
}
