using AutoMapper;
using SearchAndRescue.Category.Contracts.Services;
using SearchAndRescue.Configuration.Dtos.Get;
using SearchAndRescue.ContactType.Contracts.Services;
using SearchAndRescue.Entity.Contracts.Services;
using SearchAndRescue.Favourite.Contracts.Services;
using SearchAndRescue.Feature.Contracts.Services;
using SearchAndRescue.Keyword.Contracts.Services;
using SearchAndRescue.POI.Contracts.Services;
using SearchAndRescue.Role.Contracts.Services;
using SearchAndRescue.Sectors.Contracts.Services;
using IRepo = SearchAndRescue.Configuration.Contracts.Repositories.IConfiguration;

namespace SearchAndRescue.Configuration.Services
{
    public class Configuration : Contracts.Services.IConfiguration
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;
        private readonly ICategory _category;
        private readonly IContactType _contactType;
        private readonly IEntity _entity;
        private readonly IFavourite _favourite;
        private readonly IFeature _feature;
        private readonly IKeyword _keyword;
        private readonly IPointOfInterest _poi;
        private readonly IRole _role;
        private readonly ISector _sector;

        public Configuration(IMapper mapper, IFavourite favourite, ICategory category, IContactType contactType, IEntity entity, IFeature feature, IKeyword keyword, IPointOfInterest poi, IRole role, ISector sector, IRepo repo)
        {
            _mapper = mapper;
            _favourite = favourite;
            _category = category;
            _contactType = contactType;
            _entity = entity;
            _feature = feature;
            _keyword = keyword;
            _poi = poi;
            _role = role;
            _sector = sector;
            _repo = repo;
        }

        public async Task<Dtos.Get.Configuration> GetAsync()
        {
            Dtos.Get.Configuration configuration = new();

            configuration.Categories = _mapper.Map<IEnumerable<Category.Dtos.Get.Category>>(await _category.GetCategoriesAsync());
            configuration.EntityTypes = _mapper.Map<IEnumerable<Entity.Dtos.Get.EntityType>>(await _entity.GetEntityTypesAsync());
            configuration.Sectors = _mapper.Map<IEnumerable<Sectors.Dtos.Get.Sector>>(await _sector.GetSectorsAsync());
            configuration.ContactTypes = _mapper.Map<IEnumerable<ContactType.Dtos.Get.ContactType>>(await _contactType.GetContactTypesAsync());
            configuration.PointOfInterests = _mapper.Map<IEnumerable<POI.Dtos.Get.PointOfInterest>>(await _poi.GetPointOfInterestsAsync());
            configuration.EntityFavourites = _mapper.Map<IEnumerable<Favourite.Dtos.Get.EntityFavourite>>(await _favourite.GetEntityFavouritesAsync());
            configuration.ProductFavourites = _mapper.Map<IEnumerable<Favourite.Dtos.Get.ProductFavourite>>(await _favourite.GetProductFavouritesAsync());
            configuration.FeaturePermissions = _mapper.Map<IEnumerable<Feature.Dtos.Get.FeaturePermission>>(await _feature.GetFeaturePermissionsAsync());
            configuration.Permissions = _mapper.Map<IEnumerable<Dtos.Get.Permission>>(await GetPermissionsAsync());
            configuration.Features = _mapper.Map<IEnumerable<Feature.Dtos.Get.Feature>>(await _feature.GetFeaturesAsync());
            configuration.Keywords = _mapper.Map<IEnumerable<Keyword.Dtos.Get.Keyword>>(await _keyword.GetKeywordsAsync());
            configuration.Roles = _mapper.Map<IEnumerable<Role.Dtos.Get.Role>>(await _role.GetRolesAsync());
            configuration.SectorServices = _mapper.Map<IEnumerable<Sectors.Dtos.Get.SectorService>>(await _sector.GetSectorServicesAsync());
            configuration.FavouriteTypes = _mapper.Map<IEnumerable<Favourite.Dtos.Get.FavouriteType>>(await _favourite.GetFavouriteTypesAsync());

            return configuration;
        }

        public async Task<Permission> GetPermissionAsync(Guid id)
        {
            Dtos.Get.Permission permission = new();
            permission.Id = id;
            Database.Models.Permission? model = _mapper.Map<Database.Models.Permission>(permission);
            model = await _repo.GetPermissionAsync(model);
            return _mapper.Map<Dtos.Get.Permission>(model);
        }

        public async Task<IEnumerable<Permission>> GetPermissionsAsync()
        {
            IEnumerable<Database.Models.Permission>? result = await _repo.GetPermissionsAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.Permission>>(result);
        }
    }
}
