using AutoMapper;
using SearchAndRescue.User.Contracts;
using SearchAndRescue.User.Contracts.Repositories;
using SearchAndRescue.User.Dtos.Get;

namespace SearchAndRescue.User.Services
{
    public class Login : ILogin
    {
        private readonly IUser _repository;
        private readonly IMapper _mapper;

        public Login(IMapper mapper, IUser repostory)
        {
            _repository = repostory;
            _mapper = mapper;
        }

        public async Task<LoginUser> Authenticate(Dtos.Post.User login)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(login);
            var result = await _repository.TryGet(userRegistration);
            LoginUser loginUser = _mapper.Map<LoginUser>(result);
            if (loginUser.Id.HasValue)
            {
                loginUser.FeaturePermissions = await GetFeaturePermissionsAsync(loginUser.Id.Value);
            }
            return loginUser;
        }

        public async Task<int> Register(Dtos.Post.User registration)
        {
            Database.Models.User userRegistration = _mapper.Map<Database.Models.User>(registration);
            return await _repository.Create(userRegistration);
        }

        public async Task<LoginUser> SignInAsync(LoginUser login)
        {
            Database.Models.User userLogin = _mapper.Map<Database.Models.User>(login);
            userLogin = await _repository.Get(userLogin);
            login = _mapper.Map<LoginUser>(userLogin);
            return login;
        }

        private async Task<IEnumerable<FeaturePermission>> GetFeaturePermissionsAsync(Guid userid)
        {
            IEnumerable<FeaturePermission> featurePermissions = _mapper.Map<IEnumerable<FeaturePermission>>(await _repository.GetFeaturePermissions(userid));
            return featurePermissions;
        }
    }
}
