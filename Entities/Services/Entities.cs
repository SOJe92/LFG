﻿using AutoMapper;
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

        public async Task<IEnumerable<Dtos.Get.Entities>> Get(Guid id)
        {
            var entities = await _entitiesRepository.Get(id);
            return _mapper.Map<IEnumerable<Dtos.Get.Entities>>(entities);
        }

        public async Task<IEnumerable<Dtos.Get.Entities>> Get()
        {
            var entities = await _entitiesRepository.Get();
            return _mapper.Map<IEnumerable<Dtos.Get.Entities>>(entities);
        }
    }
}
