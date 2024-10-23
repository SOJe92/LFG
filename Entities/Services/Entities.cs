using AutoMapper;
using SearchAndRescue.Entities.Contracts.Services;
using SearchAndRescue.Entities.Dtos.Get;
using IEntitiesRepository = SearchAndRescue.Entities.Contracts.Repositories.IEntities;

namespace SearchAndRescue.Entities.Services
{
    public class Entities : IEntities
    {
        private readonly IEntitiesRepository _entitiesRepository;
        private readonly IMapper _mapper;

        public Entities(IEntitiesRepository entitiesRepository, IMapper mapper)
        {
            _entitiesRepository = entitiesRepository;
            _mapper = mapper;
        }

        public async Task<int> Add(Dtos.Post.Entity entity)
        {
            var result = await _entitiesRepository.Add(entity);
            
            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _entitiesRepository.Delete(id);
        }

        public async Task<Entity> Get(Guid id)
        {
            return _mapper.Map<Entity>(await _entitiesRepository.Get(id));
        }

        public async Task<IEnumerable<Entity>> GetAll(Guid id)
        {
            var entities = await _entitiesRepository.GetAll(id);
            return _mapper.Map<IEnumerable<Entity>>(entities);
        }

        public async Task<bool> Update(Dtos.Put.Entity entity)
        {
            return await _entitiesRepository.Update(entity);
        }
    }
}
