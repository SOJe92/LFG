using AutoMapper;
using SearchAndRescue.Configuration.Dtos.Get;
using SearchAndRescue.Favourite.Contracts.Services;
using IConfigurationRepository = SearchAndRescue.Configuration.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.Configuration.Services
{
    public class Configuration : Contracts.Services.IConfiguration
    {
        private readonly IConfigurationRepository _repo;
        private readonly IMapper _mapper;
        private readonly IFavourite _favourite;

        public Configuration(IConfigurationRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Dtos.Get.Configuration> GetAsync()
        {
            Dtos.Get.Configuration configuration = new();

            configuration.Categories = _mapper.Map<IEnumerable<Category>>(await _repo.GetCategoriesAsync());
            configuration.EntityTypes = _mapper.Map<IEnumerable<EntityType>>(await _repo.GetEntityTypesAsync());
            configuration.Sectors = _mapper.Map<IEnumerable<Sector>>(await _repo.GetSectorsAsync());
            configuration.ContactTypes = _mapper.Map<IEnumerable<ContactType>>(await _repo.GetContactTypesAsync());
            configuration.PointOfInterests = _mapper.Map<IEnumerable<PointOfInterest>>(await _repo.GetPointOfInterestsAsync());
            configuration.EntityFavourites = _mapper.Map<IEnumerable<EntityFavourites>>(await _repo.GetEntityFavouritesAsync());
            configuration.ProductFavourites = _mapper.Map<IEnumerable<ProductFavourites>>(await _repo.GetProductFavouritesAsync());
            configuration.Features = _mapper.Map<IEnumerable<Feature>>(await _repo.GetFeaturesAsync());
            configuration.Keywords = _mapper.Map<IEnumerable<Keyword>>(await _repo.GetKeywordsAsync());
            configuration.Roles = _mapper.Map<IEnumerable<Role>>(await _repo.GetRolesAsync());
            configuration.SectorServices = _mapper.Map<IEnumerable<SectorService>>(await _repo.GetSectorServicesAsync());
            configuration.FavouriteTypes = _mapper.Map<IEnumerable<Favourite.Dtos.Get.FavouriteType>>(await _favourite.GetFavouriteTypesAsync());

            return configuration;
        }
    }
}
