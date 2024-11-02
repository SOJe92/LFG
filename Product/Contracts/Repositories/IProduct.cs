namespace SearchAndRescue.Product.Contracts.Repositories
{
    public interface IProduct
    {
        Task<Database.Models.Product> Get(Guid id);
        Task<int> Add(Database.Models.Product product);
        Task<bool> Update(Database.Models.Product product);
        Task<bool> Delete(Guid id);
    }
}
