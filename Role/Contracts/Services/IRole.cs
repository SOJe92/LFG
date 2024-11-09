namespace SearchAndRescue.Role.Contracts.Services
{
    public interface IRole
    {
        Task<IEnumerable<Dtos.Get.Role>> GetRolesAsync();
        Task<Dtos.Get.Role> GetRoleAsync(Dtos.Get.Role role);
    }
}
