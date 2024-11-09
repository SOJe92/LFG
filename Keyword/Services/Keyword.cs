using AutoMapper;
using SearchAndRescue.Keyword.Contracts.Services;
using IRepo = SearchAndRescue.Keyword.Contracts.Repositories.IKeyword;

namespace SearchAndRescue.Keyword.Services
{
    public class Keyword : IKeyword
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public Keyword(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Dtos.Get.Keyword> GetKeywordAsync(Dtos.Get.Keyword feature)
        {
            var model = _mapper.Map<Database.Models.Keyword>(feature);
            return _mapper.Map<Dtos.Get.Keyword>(await _repo.GetKeywordAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.Keyword>> GetKeywordsAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.Keyword>>(await _repo.GetKeywordsAsync());
        }
    }
}
