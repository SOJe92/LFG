namespace SearchAndRescue.Configuration.Contracts.Services
{
    public interface IConfiguration
    {
        Task<IEnumerable<Dtos.Get.Sector>> GetSectors();
    }
}
