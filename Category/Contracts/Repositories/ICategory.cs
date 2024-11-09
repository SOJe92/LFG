namespace SearchAndRescue.Category.Contracts.Repositories
{
    public interface ICategory
    {
        Task<Database.Models.Category> GetCategoryAsync(Database.Models.Category category);

        Task<IEnumerable<Database.Models.Category>> GetCategoriesAsync();
    }
}
