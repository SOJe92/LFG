namespace SearchAndRescue.Configuration.Contracts.Services
{
    public interface IConfiguration
    {
        Task<Dtos.Get.Configuration> GetAsync();
        Task<Dtos.Get.Permission> GetPermissionAsync(Guid id);
        Task<IEnumerable<Dtos.Get.Permission>> GetPermissionsAsync();
    }
}
