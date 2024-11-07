using AutoMapper;
using SearchAndRescue.User.Contracts.Services;
using IRepo = SearchAndRescue.User.Contracts.Repositories.IUser;

namespace SearchAndRescue.User.Services
{
    public class User : IUser
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public User(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<Guid> AddContactTypeAsync(Dtos.Post.ContactType contactType)
        {
            var model = _mapper.Map<Database.Models.ContactType>(contactType);
            var result = await _repo.AddContactTypeAsync(model);
            return result;
        }

        public async Task<Guid> AddEntityAsync(Dtos.Post.Entity entity)
        {
            var model = _mapper.Map<Database.Models.Entity>(entity);
            var result = await _repo.AddEntityAsync(model);
            return result;
        }

        public async Task<Guid> AddFavouriteAsync(Dtos.Post.Favourite favourite)
        {
            var model = _mapper.Map<Database.Models.Favourite>(favourite);
            var result = await _repo.AddFavouriteAsync(model);
            return result;
        }

        public async Task<Guid> AddKeywordAsync(Dtos.Post.Keyword keyword)
        {
            var model = _mapper.Map<Database.Models.Keyword>(keyword);
            var result = await _repo.AddKeywordAsync(model);
            return result;
        }

        public async Task<Guid> AddPointOfInterestAsync(Dtos.Post.PointOfInterest poi)
        {
            var model = _mapper.Map<Database.Models.PointOfInterest>(poi);
            var result = await _repo.AddPointOfInterestAsync(model);
            return result;
        }

        public async Task<Guid> AddProductAsync(Dtos.Post.Product product)
        {
            var model = _mapper.Map<Database.Models.Product>(product);
            var result = await _repo.AddProductAsync(model);
            return result;
        }

        public async Task<Guid> AddSectorServiceAsync(Dtos.Post.SectorService sectorService)
        {
            var model = _mapper.Map<Database.Models.SectorService>(sectorService);
            var result = await _repo.AddSectorServiceAsync(model);
            return result;
        }

        public async Task<Guid> AddUserAsync(Dtos.Post.ChildUser user)
        {
            var model = _mapper.Map<Database.Models.ChildUser>(user);
            var result = await _repo.AddUserAsync(model);
            return result;
        }

        public async Task<Guid> CreateSettingsAsync(Dtos.Post.Setting setting)
        {
            var model = _mapper.Map<Database.Models.Setting>(setting);
            var result = await _repo.CreateSettingsAsync(model);
            return result;
        }

        public async Task<bool> DeleteContactTypeAsync(Guid id)
        {
            Database.Models.ContactType model = new();
            model.Id = id;
            var result = await _repo.DeleteContactTypeAsync(model);
            return result;
        }

        public async Task<bool> DeleteEntityAsync(Guid userId, Guid id)
        {
            Database.Models.Entity model = new();
            model.Id = id;
            model.UserId = userId;
            var result = await _repo.DeleteEntityAsync(model);
            return result;
        }

        public async Task<bool> DeleteFavouriteAsync(Guid id)
        {
            Database.Models.Favourite model = new();
            model.Id = id;
            var result = await _repo.DeleteFavouriteAsync(model);
            return result;
        }

        public async Task<bool> DeleteKeywordAsync(Guid id)
        {
            Database.Models.Keyword model = new();
            model.Id = id;
            var result = await _repo.DeleteKeywordAsync(model);
            return result;
        }

        public async Task<bool> DeletePointOfInterestAsync(Guid userId, Guid id)
        {
            Database.Models.PointOfInterest model = new();
            model.Id = id;
            model.UserId = userId;
            var result = await _repo.DeletePointOfInterestAsync(model);
            return result;
        }

        public async Task<bool> DeleteProductAsync(Guid userId, Guid id)
        {
            Database.Models.Product model = new();
            model.Id = id;
            model.UserId = userId;
            var result = await _repo.DeleteProductAsync(model);
            return result;
        }

        public async Task<bool> DeleteSectorServiceAsync(Guid id)
        {
            Database.Models.SectorService model = new();
            model.Id = id;
            var result = await _repo.DeleteSectorServiceAsync(model);
            return result;
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            Database.Models.ChildUser model = new();
            model.Id = id;
            var result = await _repo.DeleteUserAsync(model);
            return result;
        }

        public async Task<IEnumerable<Dtos.Get.ContactType>> GetContactTypesAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.ContactType>>( await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<IEnumerable<Dtos.Get.Entity>> GetEntitiesAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.Entity>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.Entity> GetEntityAsync(Dtos.Get.Entity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Dtos.Get.Favourite> GetFavouriteAsync(Dtos.Get.Favourite favourite)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.Favourite>> GetFavouritesAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.Favourite>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.Feature> GetFeatureAsync(Dtos.Get.Feature feature)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.Feature>> GetFeaturesAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.Feature>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.Keyword> GetKeywordAsync(Dtos.Get.Keyword keyword)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.Keyword>> GetKeywordsAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.Keyword>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.PointOfInterest> GetPointOfInterestAsync(Dtos.Get.PointOfInterest poi)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.PointOfInterest>> GetPointOfInterestsAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.PointOfInterest>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.Entity> GetProductAsync(Dtos.Get.Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.Product>> GetProductsAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.Product>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.Role> GetRoleAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Dtos.Get.SectorService> GetSectorAsync(Dtos.Get.SectorService sectorService)
        {
            throw new NotImplementedException();
        }

        public async Task<Dtos.Get.SectorService> GetSectorServiceAsync(Dtos.Get.SectorService sectorService)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.SectorService>> GetSectorServicesAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.SectorService>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<Dtos.Get.Setting> GetSettingAsync(Dtos.Get.Setting setting)
        {
            throw new NotImplementedException();
        }

        public async Task<Dtos.Get.User> GetUserAsync(Dtos.Get.ChildUser user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dtos.Get.ChildUser>> GetUsersAsync(Guid userId)
        {
            var result = _mapper.Map<IEnumerable<Dtos.Get.ChildUser>>(await _repo.GetContactTypesAsync(userId));
            return result;
        }

        public async Task<bool> SetRoleAsync(Dtos.Post.Role role)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> UpdateFeatureAsync(Dtos.Post.Feature feature)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateSettingsAsync(Dtos.Post.Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}
