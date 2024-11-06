namespace SearchAndRescue.Startup
{
    using SearchAndRescue.Core.Database.Contracts;
    using SearchAndRescue.Core.Database.Services;
    using SearchAndRescue.User.Contracts;

    using ExternalUserService = External.Services.User;
    using IExternalUserService = External.Contracts.Services.IUser;
    using LoginService = User.Services.Login;
    using IEntityService = Entity.Contracts.Services.IEntity;
    using EntityService = Entity.Services.Entity;
    using IEntitiesService = Entities.Contracts.Services.IEntities;
    using EntitiesService = Entities.Services.Entities;
    using IUserService = User.Contracts.Services.IUser;
    using UserService = User.Services.User;
    using IConfigurationService = Configuration.Contracts.Services.IConfiguration;
    using ConfigurationService = Configuration.Services.Configuration;
    using IUserConfigurationService = User.Contracts.Services.IConfiguration;
    using UserConfigurationService = User.Services.Configuration;
    using SearchAndRescue.Search.Contracts.Services;
    using SearchAndRescue.Search.Services;
    using SearchAndRescue.Search.Dtos;

    public static class ServicesRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDbService, DbService>();
            serviceCollection.AddSingleton(MapperConfig.Initialize());
            serviceCollection.AddTransient<ILogin, LoginService>();
            serviceCollection.AddTransient<ISearchResponseService<EntitiesSearchResult>, EntitySearchResponseService>();
            serviceCollection.AddTransient<ISearchResponseService<ProductsSearchResult>, ProductSearchResponseService>();
            serviceCollection.AddTransient<IExternalUserService, ExternalUserService>();
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<IEntitiesService, EntitiesService>();
            serviceCollection.AddTransient<IEntityService, EntityService>();
            serviceCollection.AddTransient<IConfigurationService, ConfigurationService>();
            serviceCollection.AddTransient<IUserConfigurationService, UserConfigurationService>();
        }
    }
}
