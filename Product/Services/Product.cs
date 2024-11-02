using AutoMapper;
using SearchAndRescue.Product.Contracts.Services;
using IProductRepository = SearchAndRescue.Product.Contracts.Repositories.IProduct;

namespace SearchAndRescue.Product.Services
{
    public class Product : IProduct
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public Product(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<int> Add(Dtos.Post.Product product)
        {
            Database.Models.Product model = _mapper.Map<Database.Models.Product>(product);
            var result = await _productRepository.Add(model);

            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _productRepository.Delete(id);
        }

        public async Task<Dtos.Get.Product> Get(Guid id)
        {
            return _mapper.Map<Dtos.Get.Product>(await _productRepository.Get(id));
        }

        public async Task<bool> Update(Dtos.Put.Product product)
        {
            Database.Models.Product model = _mapper.Map<Database.Models.Product>(product);
            return await _productRepository.Update(model);
        }
    }
}
