using AutoMapper;
using SearchAndRescue.Entity.Contracts.Services;
using SearchAndRescue.Entity.Database.Models;
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

        public async Task<int> AddAsync(Dtos.Post.Entity entity)
        {
            Database.Models.Entity model = _mapper.Map<Database.Models.Entity>(entity);
            var result = await _entityRepository.AddAsync(model);

            return result;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _entityRepository.DeleteAsync(id);
        }

        public async Task<Dtos.Get.Entity> GetAsync(Guid id)
        {
            return _mapper.Map<Dtos.Get.Entity>(await _entityRepository.GetAsync(id));
        }

        public async Task<Dtos.Get.EntityType> GetEntityTypeAsync(Dtos.Get.EntityType entityType)
        {
            var model = _mapper.Map<Database.Models.EntityType>(entityType);
            return _mapper.Map<Dtos.Get.EntityType>(await _entityRepository.GetEntityTypeAsync(model));
        }

        public async Task<IEnumerable<Dtos.Get.EntityType>> GetEntityTypesAsync()
        {
            return _mapper.Map<IEnumerable<Dtos.Get.EntityType>>(await _entityRepository.GetEntityTypesAsync());
        }

        public async Task<bool> UpdateAsync(Dtos.Put.Entity entity)
        {
            Database.Models.Entity model = _mapper.Map<Database.Models.Entity>(entity);
            return await _entityRepository.UpdateAsync(model);
        }
    }
}
