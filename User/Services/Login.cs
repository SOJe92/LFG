using AutoMapper;
using SearchAndRescue.User.Contracts;
using IConfiguration = SearchAndRescue.User.Contracts.Services.IConfiguration;
using IRepo = SearchAndRescue.User.Contracts.Repositories.IUser;
using IService = SearchAndRescue.User.Contracts.Services.IUser;

namespace SearchAndRescue.User.Services
{
    public class Login : ILogin
    {
        private readonly IRepo _repository;
        private readonly IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly IService _service;

        public Login(IMapper mapper, IRepo repostory, IService service, IConfiguration config)
        {
            _repository = repostory;
            _mapper = mapper;
            _service = service;
            _config = config;
        }

        public async Task<Dtos.Get.User> Authenticate(Dtos.Post.User login)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(login);
            userRegistration = await _repository.GetByEmailAsync(userRegistration);
            Dtos.Get.User loginUser = _mapper.Map<Dtos.Get.User>(userRegistration);
            loginUser.Configuration = await _config.GetAsync(loginUser.Id);
            return loginUser;
        }

        public async Task<Guid> Register(Dtos.Post.User registration)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(registration);
            return await _repository.AddAsync(userRegistration);
        }

        public async Task<Dtos.Get.User> SignInAsync(Dtos.Post.User login)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(login);
            userRegistration = await _repository.GetAsync(userRegistration);
            Dtos.Get.User loginUser = _mapper.Map<Dtos.Get.User>(userRegistration);
            loginUser.Configuration = await _config.GetAsync(loginUser.Id);
            return loginUser;
        }
    }
}
