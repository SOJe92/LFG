using AutoMapper;
using SearchAndRescue.User.Dtos.Get;
using UserEntity = SearchAndRescue.User.Database.Models.User;

namespace SearchAndRescue.User.Database
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoginUser, UserEntity>();
            CreateMap<UserEntity, LoginUser>();
            CreateMap<Dtos.Post.User, UserEntity>();
            CreateMap<UserEntity, Dtos.Post.User>();
            CreateMap<FeaturePermission, Models.Feature>();
            CreateMap<Models.Feature, FeaturePermission>();
            CreateMap<Dtos.Get.Configuration, Models.Setting>();
            CreateMap<Models.Setting, Dtos.Get.Configuration>();
        }
    }
}
