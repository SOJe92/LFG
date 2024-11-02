namespace SearchAndRescue.User.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<Models.Configuration> GetAsync(Guid id);

        Task<bool> SetAsync(Guid id, Models.Configuration config);
    }
}
