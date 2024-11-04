namespace SearchAndRescue.Configuration.Contracts.Services
{
    public interface IConfiguration
    {
        Task<Dtos.Get.Configuration> GetAsync();
    }
}
