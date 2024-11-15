namespace SearchAndRescue.Admin.Contracts.Repositories
{
    public interface IAdmin
    {
        Task<IEnumerable<Database.Models.User>> GetUsersAsync();
        Task<Database.Models.User> GetUserAsync(Guid id);
        Task<bool> UpdateUserAsync(Database.Models.User user);
    }
}
