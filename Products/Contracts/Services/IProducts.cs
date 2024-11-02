namespace SearchAndRescue.Products.Contracts.Services
{
    public interface IProducts
    {
        Task<IEnumerable<Dtos.Get.Products>> GetAsync();

        Task<IEnumerable<Dtos.Get.Products>> GetAsync(Guid id);
    }
}
