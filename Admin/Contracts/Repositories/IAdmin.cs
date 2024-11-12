namespace SearchAndRescue.Admin.Contracts.Repositories
{
    public interface IAdmin
    {
        Task<IEnumerable<Database.Models.User>> GetUsersAsync();
    }
}
