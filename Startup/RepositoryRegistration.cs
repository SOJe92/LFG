using IUserRepository = SearchAndRescue.User.Contracts.Repositories.IUser;
using UserRepository = SearchAndRescue.User.Repositories.User;
using IExternalUserRepository = SearchAndRescue.External.Contracts.Repositories.IUser;
using ExternalUserRepository = SearchAndRescue.External.Repositories.User;
using IEntityRepository = SearchAndRescue.Entity.Contracts.Repositories.IEntity;
using EntityRepository = SearchAndRescue.Entity.Repositories.Entity;
using IEntitiesRepository = SearchAndRescue.Entities.Contracts.Repositories.IEntities;
using EntitiesRepository = SearchAndRescue.Entities.Repositories.Entities;
using IConfigurationRepository = SearchAndRescue.Configuration.Contracts.Repositories.IConfiguration;
using ConfigurationRepository = SearchAndRescue.Configuration.Repositories.Configuration;

namespace SearchAndRescue.Startup
{
    public static class RepositoryRegistration
    {
        public static void RegisterRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddTransient<IExternalUserRepository, ExternalUserRepository>();
            serviceCollection.AddTransient<IEntitiesRepository, EntitiesRepository>();
            serviceCollection.AddTransient<IEntityRepository, EntityRepository>();
            serviceCollection.AddTransient<IConfigurationRepository, ConfigurationRepository>();
        }
    }
}
