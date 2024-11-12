namespace SearchAndRescue.Admin.Contracts.Services
{
    public interface IAdmin
    {
        Task<IEnumerable<Dtos.Get.User>> GetUsersAsync();
    }
}
