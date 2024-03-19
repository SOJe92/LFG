using AutoMapper;
using UserMappingProfile = SearchAndRescue.User.Database.MappingProfile;
using ExternalMappingProfile = SearchAndRescue.External.Database.MappingProfile;
using EntityMappingProfile = SearchAndRescue.Entities.Database.MappingProfile;
using ConfigMappingProfile = SearchAndRescue.Configuration.Database.MappingProfile;

namespace SearchAndRescue
{
    public static class MapperConfig
    {
        public static IMapper Initialize()
        {
            return Configuration.CreateMapper();
        }

        static MapperConfiguration Configuration = new(cfg =>
        {
            cfg.AddProfile(new UserMappingProfile());
            cfg.AddProfile(new ExternalMappingProfile());
            cfg.AddProfile(new EntityMappingProfile());
            cfg.AddProfile(new ConfigMappingProfile());
        });
    }
}
