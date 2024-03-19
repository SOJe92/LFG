namespace SearchAndRescue.Helpers
{
    using AutoMapper;
    using SearchAndRescue.User.Dtos.Get;

    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User.Dtos.Post.User, LoginUser>();
        }
    }
}
