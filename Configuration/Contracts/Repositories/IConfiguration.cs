namespace SearchAndRescue.Configuration.Contracts.Repositories
{
    public interface IConfiguration
    {
        Task<Database.Models.Permission> GetPermissionAsync(Database.Models.Permission permission);
        Task<IEnumerable<Database.Models.Permission>> GetPermissionsAsync();
    }
}
