using AutoMapper;
using SearchAndRescue.ContactType.Contracts.Services;
using IRepo = SearchAndRescue.ContactType.Contracts.Repositories.IContactType;

namespace SearchAndRescue.ContactType.Services
{
    public class ContactType : IContactType
    {
        private readonly IMapper _mapper;
        private readonly IRepo _repo;

        public ContactType(IMapper mapper, IRepo repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<Dtos.Get.ContactType> GetContactTypeAsync(Dtos.Get.ContactType contactType)
        {
            var model = _mapper.Map<Database.Models.ContactType>(contactType);
            return _mapper.Map<Dtos.Get.ContactType>(await _repo.GetContactTypeAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.ContactType>> GetContactTypesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.ContactType>>(await _repo.GetContactTypesAsync());
        }
    }
}
