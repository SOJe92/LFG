namespace SearchAndRescue.User.Contracts.Services
{
    public interface IConfiguration
    {
        Task<Dtos.Get.Configuration> GetAsync(Guid id);

        Task<bool> UpdateAsync(Guid id, Dtos.Put.Configuration config);
    }
}
