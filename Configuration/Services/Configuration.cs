using AutoMapper;
using SearchAndRescue.Configuration.Dtos.Get;
using IConfigurationRepository = SearchAndRescue.Configuration.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.Configuration.Services
{
    public class Configuration : Contracts.Services.IConfiguration
    {
        private readonly IConfigurationRepository _configuration;
        private readonly IMapper _mapper;

        public Configuration(IConfigurationRepository configurationRepository, IMapper mapper)
        {
            _configuration = configurationRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Sector>> GetSectors()
        {
            IEnumerable<Sector> sectors = _mapper.Map<IEnumerable<Sector>>(await _configuration.GetSectorsAsync());

            return sectors;
        }
    }
}
