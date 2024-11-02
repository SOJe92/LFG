namespace SearchAndRescue.Products.Contracts.Repositories
{
    public interface IProducts
    {
        Task<IEnumerable<Database.Models.Products>> GetAsync();
        Task<IEnumerable<Database.Models.Products>> GetAsync(Guid id);
    }
}
