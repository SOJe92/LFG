using AutoMapper;
using SearchAndRescue.POI.Contracts.Services;
using IRepo = SearchAndRescue.POI.Contracts.Repositories.IPointOfInterest;

namespace SearchAndRescue.POI.Services
{
    public class PointOfInterest : IPointOfInterest
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public PointOfInterest(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Dtos.Get.PointOfInterest> GetPointOfInterestAsync(Dtos.Get.PointOfInterest poi)
        {
            var model = _mapper.Map<Database.Models.PointOfInterest>(poi);
            return _mapper.Map<Dtos.Get.PointOfInterest>(await _repo.GetPointOfInterestAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.PointOfInterest>> GetPointOfInterestsAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.PointOfInterest>>(await _repo.GetPointOfInterestsAsync());
        }
    }
}
