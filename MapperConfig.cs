namespace SearchAndRescue
{
    using AutoMapper;
    using AdminMappingProfile = Admin.Database.MappingProfile;
    using UserMappingProfile = User.Database.MappingProfile;
    using ExternalMappingProfile = External.Database.MappingProfile;
    using EntitiesMappingProfile = Entities.Database.MappingProfile;
    using CategoryMappingProfile = Category.Database.MappingProfile;
    using ConfigurationMappingProfile = Configuration.Database.MappingProfile;
    using ContactTypeMappingProfile = ContactType.Database.MappingProfile;
    using FavouriteMappingProfile = Favourite.Database.MappingProfile;
    using EntityMappingProfile = Entity.Database.MappingProfile;
    using FeatureMappingProfile = Feature.Database.MappingProfile;
    using KeywordMappingProfile = Keyword.Database.MappingProfile;
    using POIMappingProfile = POI.Database.MappingProfile;
    using ProductMappingProfile = Product.Database.MappingProfile;
    using ProductsMappingProfile = Products.Database.MappingProfile;
    using RoleMappingProfile = Role.Database.MappingProfile;
    using SectorsMappingProfile = Sectors.Database.MappingProfile;

    public static class MapperConfig
    {
        public static IMapper Initialize()
        {
            return Configuration.CreateMapper();
        }

        static MapperConfiguration Configuration = new(cfg =>
        {
            cfg.AddProfile(new AdminMappingProfile());
            cfg.AddProfile(new UserMappingProfile());
            cfg.AddProfile(new ExternalMappingProfile());
            cfg.AddProfile(new ConfigurationMappingProfile());
            cfg.AddProfile(new EntityMappingProfile());
            cfg.AddProfile(new EntitiesMappingProfile());
            cfg.AddProfile(new CategoryMappingProfile());
            cfg.AddProfile(new ContactTypeMappingProfile());
            cfg.AddProfile(new FavouriteMappingProfile());
            cfg.AddProfile(new FeatureMappingProfile());
            cfg.AddProfile(new KeywordMappingProfile());
            cfg.AddProfile(new POIMappingProfile());
            cfg.AddProfile(new ProductMappingProfile());
            cfg.AddProfile(new ProductsMappingProfile());
            cfg.AddProfile(new RoleMappingProfile());
            cfg.AddProfile(new SectorsMappingProfile());
        });
    }
}
