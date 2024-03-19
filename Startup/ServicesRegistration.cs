namespace SearchAndRescue.Startup
{
    using SearchAndRescue.Core.Database.Contracts;
    using SearchAndRescue.Core.Database.Services;
    using SearchAndRescue.User.Contracts;

    using ExternalUserService = External.Services.User;
    using IExternalUserService = External.Contracts.Services.IUser;
    using LoginService = User.Services.Login;
    using IEntitiesService = Entities.Contracts.Services.IEntities;
    using EntitiesService = Entities.Services.Entities;
    using IConfigurationService = Configuration.Contracts.Services.IConfiguration;
    using ConfigurationService = Configuration.Services.Configuration;

    public static class ServicesRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDbService, DbService>();
            serviceCollection.AddSingleton(MapperConfig.Initialize());
            serviceCollection.AddTransient<ILogin, LoginService>();
            serviceCollection.AddTransient<IExternalUserService, ExternalUserService>();
            serviceCollection.AddTransient<IEntitiesService, EntitiesService>();
            serviceCollection.AddTransient<IConfigurationService, ConfigurationService>();
        }
    }
}
