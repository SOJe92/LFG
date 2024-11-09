namespace SearchAndRescue.Category.Contracts.Services
{
    public interface ICategory
    {
        Task<Dtos.Get.Category> GetCategoryAsync(Dtos.Get.Category category);

        Task<IEnumerable<Dtos.Get.Category>> GetCategoriesAsync();
    }
}
