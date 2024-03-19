namespace SearchAndRescue.Configuration.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<IEnumerable<Models.Sector>> GetSectorsAsync();
    }
}
