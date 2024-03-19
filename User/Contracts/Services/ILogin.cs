using SearchAndRescue.User.Dtos.Get;
using SearchAndRescue.User.Dtos.Post;

namespace SearchAndRescue.User.Contracts
{
    public interface ILogin
    {
        Task<LoginUser> SignInAsync(LoginUser login);

        Task<int> Register(Dtos.Post.User registration);

        Task<LoginUser> Authenticate(Dtos.Post.User login);
    }
}
