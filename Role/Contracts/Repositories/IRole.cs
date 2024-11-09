namespace SearchAndRescue.Role.Contracts.Repositories
{
    public interface IRole
    {
        Task<IEnumerable<Database.Models.Role>> GetRolesAsync();
        Task<Database.Models.Role> GetRoleAsync(Database.Models.Role role);
    }
}
