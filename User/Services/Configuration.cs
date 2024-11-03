using AutoMapper;
using IConfiguration = SearchAndRescue.User.Contracts.Services.IConfiguration;
using IRepository = SearchAndRescue.User.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.User.Services
{
    public class Configuration : IConfiguration
    {
        private readonly IRepository _repo;
        private readonly IMapper _mapper;

        public Configuration(IRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Dtos.Get.Configuration> GetAsync(Guid id)
        {
            var result = await _repo.GetAsync(id);
            return _mapper.Map<Dtos.Get.Configuration>(result);
        }

        public async Task<bool> UpdateAsync(Guid id, Dtos.Post.Configuration config)
        {
            var result = await _repo.SetAsync(id, _mapper.Map<Database.Models.Setting>(config));
            return result;
        }
    }
}
