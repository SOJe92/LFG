using SearchAndRescue.User.Contracts.Services;
using IRepo = SearchAndRescue.User.Contracts.Repositories.IUser;

namespace SearchAndRescue.User.Services
{
    public class User : IUser
    {
        private readonly IRepo _repo;
        public User(IRepo repo)
        {
            _repo = repo;

         }

        public Task<Guid> AddContactTypeAsync(Dtos.Post.ContactType contactType)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddEntityAsync(Dtos.Post.Entity entity)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddFavouriteAsync(Dtos.Post.Favourite favourite)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddKeywordAsync(Dtos.Post.Keyword keyword)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddPointOfInterestAsync(Dtos.Post.PointOfInterest poi)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddSectorServiceAsync(Dtos.Post.SectorService sectorService)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddUserAsync(Dtos.Post.User user)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> CreateSettingsAsync(Dtos.Post.Setting setting)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteContactTypeAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteEntityAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFavouriteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteKeywordAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePointOfInterestAsync(Guid userId, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSectorServiceAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.ContactType>> GetContactTypesAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.Entity>> GetEntitiesAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.Entity> GetEntityAsync(Guid userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.Favourite> GetFavouriteAsync(Guid userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.Favourite>> GetFavouritesAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.Feature> GetFeatureAsync(Guid userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.Feature>> GetFeaturesAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.Keyword> GetKeywordAsync(Guid userId, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.Keyword>> GetKeywordsAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.PointOfInterest> GetPointOfInterestAsync(Guid userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.PointOfInterest>> GetPointOfInterestsAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.Role> GetRoleAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.SectorService> GetSectorAsync(Guid userId, Guid sectorId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.SectorService> GetSectorServiceAsync(Guid userId, Guid sectorId, Guid serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.SectorService>> GetSectorServicesAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.Setting> GetSettingAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Dtos.Get.User> GetUserAsync(Guid userId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Dtos.Get.User>> GetUsersAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetRoleAsync(Dtos.Post.Role role)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UpdateFeatureAsync(Dtos.Post.Feature feature)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateSettingsAsync(Dtos.Post.Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}
