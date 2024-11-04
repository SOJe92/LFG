using AutoMapper;
using SearchAndRescue.User.Dtos.Get;
using ContactType = SearchAndRescue.User.Dtos.Base.ContactType;
using Feature = SearchAndRescue.User.Dtos.Base.Feature;
using Keyword = SearchAndRescue.User.Dtos.Base.Keyword;
using PointOfInterest = SearchAndRescue.User.Dtos.Base.PointOfInterest;
using Role = SearchAndRescue.User.Dtos.Base.Role;
using SectorService = SearchAndRescue.User.Dtos.Base.SectorService;

namespace SearchAndRescue.User.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginUser, Models.User>();
            CreateMap<Models.User, LoginUser>();
            CreateMap<Dtos.Post.User, Models.User>();
            CreateMap<Models.User, Dtos.Post.User>();
            CreateMap<FeaturePermission, Models.Feature>();
            CreateMap<Models.Feature, FeaturePermission>();
            CreateMap<Dtos.Base.Setting, Models.Setting>();
            CreateMap<Models.Setting, Dtos.Base.Setting>();

            CreateMap<ContactType, Models.ContactType>();
            CreateMap<Models.ContactType, ContactType>();
            CreateMap<Dtos.Base.Entity, Models.Entity>();
            CreateMap<Models.Entity, Dtos.Base.Entity>();
            CreateMap<Dtos.Base.Favourite, Models.Favourite>();
            CreateMap<Models.Favourite, Dtos.Base.Favourite>();
            CreateMap<Feature, Models.Feature>();
            CreateMap<Models.Feature, Feature>();
            CreateMap<Keyword, Models.Keyword>();
            CreateMap<Models.Keyword, Keyword>();
            CreateMap<PointOfInterest, Models.PointOfInterest>();
            CreateMap<Models.PointOfInterest, PointOfInterest>();
            CreateMap<Role, Models.Role>();
            CreateMap<Models.Role, Role>();
            CreateMap<SectorService, Models.SectorService>();
            CreateMap<Models.SectorService, SectorService>();
        }
    }
}
