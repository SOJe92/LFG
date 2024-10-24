using AutoMapper;
using SearchAndRescue.Entity.Contracts.Services;
using SearchAndRescue.Entity.Dtos.Get;
using IEntityRepository = SearchAndRescue.Entity.Contracts.Repositories.IEntity;

namespace SearchAndRescue.Entity.Services
{
    public class Entity : IEntity
    {
        private readonly IEntityRepository _entityRepository;
        private readonly IMapper _mapper;

        public Entity(IEntityRepository entityRepository, IMapper mapper)
        {
            _entityRepository = entityRepository;
            _mapper = mapper;
        }

        public async Task<int> Add(Dtos.Post.Entity entity)
        {
            var result = await _entityRepository.Add(entity);
            
            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _entityRepository.Delete(id);
        }

        public async Task<Dtos.Get.Entity> Get(Guid id)
        {
            return _mapper.Map<Dtos.Get.Entity>(await _entityRepository.Get(id));
        }

        public async Task<bool> Update(Dtos.Put.Entity entity)
        {
            return await _entityRepository.Update(entity);
        }
    }
}
