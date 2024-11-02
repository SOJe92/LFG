namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<Database.Models.Configuration> GetAsync(Guid id);

        Task<bool> SetAsync(Guid id, Database.Models.Configuration config);
    }
}
