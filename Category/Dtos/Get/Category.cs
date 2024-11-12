using CategoryBase = SearchAndRescue.Category.Dtos.Base.Category;
namespace SearchAndRescue.Category.Dtos.Get
{
    public class Category : CategoryBase
    {
        public Guid Id { get; set; }
    }
}
