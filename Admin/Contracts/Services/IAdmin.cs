namespace SearchAndRescue.Admin.Contracts.Services
{
    public interface IAdmin
    {
        Task<IEnumerable<Dtos.Get.User>> GetUsersAsync();
        Task<Dtos.Get.User> GetUserAsync(Guid id);
        Task<bool> UpdateUserAsync(Dtos.Put.User user);
    }
}
