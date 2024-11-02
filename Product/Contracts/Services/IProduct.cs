namespace SearchAndRescue.Product.Contracts.Services
{
    public interface IProduct
    {
        Task<Dtos.Get.Product> Get(Guid id);

        Task<int> Add(Dtos.Post.Product product);

        Task<bool> Update(Dtos.Put.Product product);

        Task<bool> Delete(Guid id);
    }
}
