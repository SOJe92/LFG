using AutoMapper;
using SearchAndRescue.Sectors.Contracts.Services;
using SearchAndRescue.Sectors.Dtos.Get;
using IRepo = SearchAndRescue.Sectors.Contracts.Repositories.ISector;

namespace SearchAndRescue.Sectors.Services
{
    public class Sector : ISector
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public Sector(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Dtos.Get.Sector> GetSectorAsync(Dtos.Get.Sector sector)
        {
            var model = _mapper.Map<Database.Models.Sector>(sector);
            return _mapper.Map<Dtos.Get.Sector>(await _repo.GetSectorAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.Sector>> GetSectorsAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.Sector>>(await _repo.GetSectorsAsync());
        }

        public async Task<SectorService> GetSectorServiceAsync(SectorService sectorService)
        {
            var model = _mapper.Map<Database.Models.SectorService>(sectorService);
            return _mapper.Map<Dtos.Get.SectorService>(await _repo.GetSectorServiceAsync(model));
        }

        public async Task<IEnumerable<SectorService>> GetSectorServicesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.SectorService>>(await _repo.GetSectorServicesAsync());
        }

        public async Task<Service> GetServiceAsync(Service service)
        {
            var model = _mapper.Map<Database.Models.Service>(service);
            return _mapper.Map<Dtos.Get.Service>(await _repo.GetServiceAsync(model));
        }

        public async Task<IEnumerable<Service>> GetServicesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.Service>>(await _repo.GetServicesAsync());
        }
    }
}
