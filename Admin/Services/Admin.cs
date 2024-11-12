using AutoMapper;
using SearchAndRescue.Admin.Contracts.Services;
using IRepo = SearchAndRescue.Admin.Contracts.Repositories.IAdmin;

namespace SearchAndRescue.Admin.Services
{
    public class Admin : IAdmin
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;

        public Admin(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Dtos.Get.User>> GetUsersAsync()
        {
            IEnumerable<Database.Models.User>? result = await _repo.GetUsersAsync();
            return _mapper.Map<IEnumerable<Dtos.Get.User>>(result);
        }
    }
}
