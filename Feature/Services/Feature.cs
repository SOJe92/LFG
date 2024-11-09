using AutoMapper;
using SearchAndRescue.Feature.Contracts.Services;
using IRepo = SearchAndRescue.Feature.Contracts.Repositories.IFeature;

namespace SearchAndRescue.Feature.Services
{
    public class Feature : IFeature
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public Feature(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Dtos.Get.Feature> GetFeatureAsync(Dtos.Get.Feature feature)
        {
            var model = _mapper.Map<Database.Models.Feature>(feature);
            return _mapper.Map<Dtos.Get.Feature>(await _repo.GetFeatureAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.Feature>> GetFeaturesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.Feature>>(await _repo.GetFeaturesAsync());
        }
    }
}
