using AutoMapper;
using SearchAndRescue.External.Contracts.Services;
using SearchAndRescue.External.Dtos.Get;
using SearchAndRescue.External.Dtos.Post;
using IUserRepository = SearchAndRescue.External.Contracts.Repositories.IUser;

namespace SearchAndRescue.External.Services
{
    public class User : IUser
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public User(IMapper mapper, IUserRepository userRepostory)
        {
            _userRepository = userRepostory;
            _mapper = mapper;
        }
    }
}
