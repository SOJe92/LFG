namespace SearchAndRescue.Startup
{
    using SearchAndRescue.Core.Database.Contracts;
    using SearchAndRescue.Core.Database.Services;
    using SearchAndRescue.Search.Contracts.Services;
    using SearchAndRescue.Search.Dtos;
    using SearchAndRescue.Search.Services;
    using SearchAndRescue.User.Contracts;
    using CategoryService = Category.Services.Category;
    using ContactTypeService = ContactType.Services.ContactType;
    using ConfigurationService = Configuration.Services.Configuration;
    using EntitiesService = Entities.Services.Entities;
    using EntityService = Entity.Services.Entity;
    using ExternalUserService = External.Services.User;
    using FavouriteService = Favourite.Services.Favourite;
    using FeatureService = Feature.Services.Feature;
    using ICategoryService = Category.Contracts.Services.ICategory;
    using IContactTypeService = ContactType.Contracts.Services.IContactType;
    using IConfigurationService = Configuration.Contracts.Services.IConfiguration;
    using IEntitiesService = Entities.Contracts.Services.IEntities;
    using IEntityService = Entity.Contracts.Services.IEntity;
    using IExternalUserService = External.Contracts.Services.IUser;
    using IFavouriteService = Favourite.Contracts.Services.IFavourite;
    using IFeatureService = Feature.Contracts.Services.IFeature;
    using IKeywordService = Keyword.Contracts.Services.IKeyword;
    using IPOIService = POI.Contracts.Services.IPointOfInterest;
    using IProductService = Product.Contracts.Services.IProduct;
    using IProductsService = Products.Contracts.Services.IProducts;
    using IRoleService = Role.Contracts.Services.IRole;
    using ISectorService = Sectors.Contracts.Services.ISector;
    using IUserConfigurationService = User.Contracts.Services.IConfiguration;
    using IUserService = User.Contracts.Services.IUser;
    using KeywordService = Keyword.Services.Keyword;
    using LoginService = User.Services.Login;
    using POIService = POI.Services.PointOfInterest;
    using ProductService = Product.Services.Product;
    using ProductsService = Products.Services.Products;
    using RoleService = Role.Services.Role;
    using SectorService = Sectors.Services.Sector;
    using UserConfigurationService = User.Services.Configuration;
    using UserService = User.Services.User;

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
            serviceCollection.AddTransient<IContactTypeService, ContactTypeService>();
            serviceCollection.AddTransient<IConfigurationService, ConfigurationService>();
            serviceCollection.AddTransient<IUserConfigurationService, UserConfigurationService>();
            serviceCollection.AddTransient<ICategoryService, CategoryService>();
            serviceCollection.AddTransient<IFavouriteService, FavouriteService>();
            serviceCollection.AddTransient<IFeatureService, FeatureService>();
            serviceCollection.AddTransient<IKeywordService, KeywordService>();
            serviceCollection.AddTransient<IPOIService, POIService>();
            serviceCollection.AddTransient<IProductService, ProductService>();
            serviceCollection.AddTransient<IProductsService, ProductsService>();
            serviceCollection.AddTransient<IRoleService, RoleService>();
            serviceCollection.AddTransient<ISectorService, SectorService>();
        }
    }
}
