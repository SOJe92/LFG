namespace SearchAndRescue.Startup
{
    using AdminRepository = Admin.Repositories.Admin;
    using CategoryRepository = Category.Repositories.Category;
    using ConfigurationRepository = Configuration.Repositories.Configuration;
    using ContactTypeRepository = ContactType.Repositories.ContactType;
    using EntitiesRepository = Entities.Repositories.Entities;
    using EntityRepository = Entity.Repositories.Entity;
    using ExternalUserRepository = External.Repositories.User;
    using FavouriteRepository = Favourite.Repositories.Favourite;
    using FeatureRepository = Feature.Repositories.Feature;
    using IAdminRepository = Admin.Contracts.Repositories.IAdmin;
    using ICategoryRepository = Category.Contracts.Repositories.ICategory;
    using IConfigurationRepository = Configuration.Contracts.Repositories.IConfiguration;
    using IContactTypeRepository = ContactType.Contracts.Repositories.IContactType;
    using IEntitiesRepository = Entities.Contracts.Repositories.IEntities;
    using IEntityRepository = Entity.Contracts.Repositories.IEntity;
    using IExternalUserRepository = External.Contracts.Repositories.IUser;
    using IFavouriteRepository = Favourite.Contracts.Repositories.IFavourite;
    using IFeatureRepository = Feature.Contracts.Repositories.IFeature;
    using IKeywordRepository = Keyword.Contracts.Repositories.IKeyword;
    using IPOIRepository = POI.Contracts.Repositories.IPointOfInterest;
    using IProductRepository = Product.Contracts.Repositories.IProduct;
    using IProductsRepository = Products.Contracts.Repositories.IProducts;
    using IRoleRepository = Role.Contracts.Repositories.IRole;
    using ISectorRepository = Sectors.Contracts.Repositories.ISector;
    using IUserRepository = User.Contracts.Repositories.IUser;
    using KeywordRepository = Keyword.Repositories.Keyword;
    using POIRepository = POI.Repositories.PointOfInterest;
    using ProductRepository = Product.Repositories.Product;
    using ProductsRepository = Products.Repositories.Products;
    using RoleRepository = Role.Repositories.Role;
    using SectorRepository = Sectors.Repositories.Sector;
    using UserRepository = User.Repositories.User;

    public static class RepositoryRegistration
    {
        public static void RegisterRepositories(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAdminRepository, AdminRepository>();
            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddTransient<IConfigurationRepository, ConfigurationRepository>();
            serviceCollection.AddTransient<IContactTypeRepository, ContactTypeRepository>();
            serviceCollection.AddTransient<IExternalUserRepository, ExternalUserRepository>();
            serviceCollection.AddTransient<IEntitiesRepository, EntitiesRepository>();
            serviceCollection.AddTransient<IEntityRepository, EntityRepository>();
            serviceCollection.AddTransient<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddTransient<IFavouriteRepository, FavouriteRepository>();
            serviceCollection.AddTransient<IFeatureRepository, FeatureRepository>();
            serviceCollection.AddTransient<IKeywordRepository, KeywordRepository>();
            serviceCollection.AddTransient<IPOIRepository, POIRepository>();
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
            serviceCollection.AddTransient<IProductsRepository, ProductsRepository>();
            serviceCollection.AddTransient<IRoleRepository, RoleRepository>();
            serviceCollection.AddTransient<ISectorRepository, SectorRepository>();
        }
    }
}
