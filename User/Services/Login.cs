using AutoMapper;
using SearchAndRescue.User.Contracts;
using IRepo = SearchAndRescue.User.Contracts.Repositories.IUser;
using IService = SearchAndRescue.User.Contracts.Services.IUser;

namespace SearchAndRescue.User.Services
{
    public class Login : ILogin
    {
        private readonly IRepo _repository;
        private readonly IMapper _mapper;
        private readonly IService _service;

        public Login(IMapper mapper, IRepo repostory, IService service)
        {
            _repository = repostory;
            _mapper = mapper;
            _service = service;
        }

        public async Task<Dtos.Get.User> Authenticate(Dtos.Post.User login)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(login);
            userRegistration = await _repository.GetUserAsync(userRegistration);
            Dtos.Get.User loginUser = _mapper.Map<Dtos.Get.User>(userRegistration);
            loginUser.Configuration = await GetConfigurationAsync(loginUser.Id);

            return loginUser;
        }

        public async Task<Guid> Register(Dtos.Post.User registration)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(registration);
            return await _repository.AddUserAsync(userRegistration);
        }

        public async Task<Dtos.Get.User> SignInAsync(Dtos.Post.User login)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(login);
            userRegistration = await _repository.GetUserAsync(userRegistration);
            Dtos.Get.User loginUser = _mapper.Map<Dtos.Get.User>(userRegistration);
            loginUser.Configuration = await GetConfigurationAsync(loginUser.Id);
            return loginUser;
        }

        private async Task<Dtos.Get.Configuration> GetConfigurationAsync(Guid userId)
        {
            Dtos.Get.Configuration config = new();
            config.Features = await _service.GetFeaturesAsync(userId);
            config.PointOfInterests = await _service.GetPointOfInterestsAsync(userId);
            config.Entities = await _service.GetEntitiesAsync(userId);
            config.ContactTypes = await _service.GetContactTypesAsync(userId);
            config.Favourites = await _service.GetFavouritesAsync(userId);
            config.Keywords = await _service.GetKeywordsAsync(userId);
            config.Role = await _service.GetRoleAsync(userId);
            config.Sectors = await _service.GetSectorServicesAsync(userId);
            config.Settings = await _service.GetSettingAsync(userId);
            config.Users = await _service.GetUsersAsync(userId);

            return config;
        }
    }
}
