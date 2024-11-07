using ProductBase = SearchAndRescue.User.Dtos.Base.Product;

namespace SearchAndRescue.User.Dtos.Get
{
    public class Product : ProductBase
    {
        public Guid Id { get; set; }
    }
}
