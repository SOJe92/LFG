using AutoMapper;
using SearchAndRescue.Role.Contracts.Services;
using IRepo = SearchAndRescue.Role.Contracts.Repositories.IRole;

namespace SearchAndRescue.Role.Services
{
    public class Role : IRole
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public Role(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Dtos.Get.Role> GetRoleAsync(Dtos.Get.Role role)
        {
            var model = _mapper.Map<Database.Models.Role>(role);
            return _mapper.Map<Dtos.Get.Role>(await _repo.GetRoleAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.Role>> GetRolesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.Role>>(await _repo.GetRolesAsync());
        }
    }
}
