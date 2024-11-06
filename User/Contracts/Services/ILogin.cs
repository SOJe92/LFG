namespace SearchAndRescue.User.Contracts
{
    public interface ILogin
    {
        Task<Dtos.Get.User> SignInAsync(Dtos.Post.User login);

        Task<Guid> Register(Dtos.Post.User registration);

        Task<Dtos.Get.User> Authenticate(Dtos.Post.User login);
    }
}
