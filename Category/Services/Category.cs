using AutoMapper;
using SearchAndRescue.Category.Contracts.Services;
using IRepo = SearchAndRescue.Category.Contracts.Repositories.ICategory;

namespace SearchAndRescue.Category.Services
{
    public class Category : ICategory
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public Category(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<IEnumerable<Dtos.Get.Category>> GetCategoriesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.Category>>(await _repo.GetCategoriesAsync());
        }

        public async Task<Dtos.Get.Category> GetCategoryAsync(Dtos.Get.Category category)
        {
            var model = _mapper.Map<Database.Models.Category>(category);
            return _mapper.Map<Dtos.Get.Category>(await _repo.GetCategoryAsync(model));
        }
    }
}
