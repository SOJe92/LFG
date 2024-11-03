namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<Database.Models.Setting> GetAsync(Guid id);

        Task<bool> SetAsync(Guid id, Database.Models.Setting config);
    }
}
