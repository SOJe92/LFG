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
            Dtos.Get.Configuration configuration = new();
            configuration.Settings = _mapper.Map<Dtos.Base.Setting>(await _repo.GetSettingsAsync(id));
            configuration.ContactTypes = _mapper.Map<IEnumerable<Dtos.Base.ContactType>>(await _repo.GetContactTypesAsync(id));
            configuration.PointOfInterests = _mapper.Map<IEnumerable<Dtos.Base.PointOfInterest>>(await _repo.GetPointOfInterestsAsync(id));
            configuration.Entities = _mapper.Map<IEnumerable<Dtos.Base.Entity>>(await _repo.GetEntitesAsync(id));
            configuration.Favourites = _mapper.Map<IEnumerable<Dtos.Base.Favourite>>(await _repo.GetFavouritesAsync(id));
            configuration.Features = _mapper.Map<IEnumerable<Dtos.Base.Feature>>(await _repo.GetFeaturesAsync(id));
            configuration.Keywords = _mapper.Map<IEnumerable<Dtos.Base.Keyword>>(await _repo.GetKeywordsAsync(id));
            configuration.Role = _mapper.Map<Dtos.Base.Role>(await _repo.GetRoleAsync(id));
            configuration.Sectors = _mapper.Map<IEnumerable<Dtos.Base.SectorService>>(await _repo.GetSectorServicesAsync(id));
            configuration.Users = _mapper.Map<IEnumerable<Dtos.Base.User>>(await _repo.GetUsersAsync(id));
            return configuration;
        }

        public async Task<bool> UpdateAsync(Guid id, Dtos.Post.Configuration config)
        {
            var result = await _repo.SetAsync(id, _mapper.Map<Database.Models.Setting>(config));
            return result;
        }
    }
}
