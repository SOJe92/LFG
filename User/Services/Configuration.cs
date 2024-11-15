using AutoMapper;
using IConfiguration = SearchAndRescue.User.Contracts.Services.IConfiguration;
using IRepository = SearchAndRescue.User.Contracts.Repositories.IUser;

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
            configuration.Settings = _mapper.Map<Dtos.Get.Setting>(await _repo.GetSettingsAsync(id));
            configuration.ContactTypes = _mapper.Map<IEnumerable<Dtos.Get.ContactType>>(await _repo.GetContactTypesAsync(id));
            configuration.PointOfInterests = _mapper.Map<IEnumerable<Dtos.Get.PointOfInterest>>(await _repo.GetPointOfInterestsAsync(id));
            configuration.Entities = _mapper.Map<IEnumerable<Dtos.Get.Entity>>(await _repo.GetEntitiesAsync(id));
            configuration.Favourites = _mapper.Map<IEnumerable<Dtos.Get.Favourite>>(await _repo.GetFavouritesAsync(id));
            configuration.FeaturePermissions = _mapper.Map<IEnumerable<Dtos.Get.FeaturePermission>>(await _repo.GetFeaturesAsync(id));
            configuration.Features = _mapper.Map<IEnumerable<Dtos.Get.Feature>>(await _repo.GetFeaturesAsync(id));
            configuration.Keywords = _mapper.Map<IEnumerable<Dtos.Get.Keyword>>(await _repo.GetKeywordsAsync(id));
            configuration.Role = _mapper.Map<Dtos.Get.Role>(await _repo.GetRoleAsync(id));
            configuration.Sectors = _mapper.Map<IEnumerable<Dtos.Get.SectorService>>(await _repo.GetSectorServicesAsync(id));
            configuration.Users = _mapper.Map<IEnumerable<Dtos.Get.User>>(await _repo.GetUsersAsync(id));
            return configuration;
        }

        public async Task<bool> UpdateAsync(Guid id, Dtos.Put.Configuration config)
        {
            var result = await _repo.UpdateSettingsAsync(_mapper.Map<Database.Models.Setting>(config));
            return result;
        }
    }
}
