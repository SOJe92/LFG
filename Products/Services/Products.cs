using AutoMapper;
using IProducts = SearchAndRescue.Products.Contracts.Services.IProducts;
using Repo = SearchAndRescue.Products.Contracts.Repositories.IProducts;

namespace SearchAndRescue.Products.Services
{
    public class Products : IProducts
    {
        private readonly Repo _repo;
        private readonly IMapper _mapper;
        public Products(Repo repo, IMapper mapper)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Dtos.Get.Products>> GetAsync()
        {
            var result = await _repo.GetAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.Products>>(result);
        }

        public async Task<IEnumerable<Dtos.Get.Products>> GetAsync(Guid id)
        {
            var result = await _repo.GetAsync(id);
            return _mapper.Map<IEnumerable<Dtos.Get.Products>>(result);
        }
    }
}
