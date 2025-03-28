﻿using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.Entity.Contracts.Services;

namespace SearchAndRescue.Entity
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IEntity _entityService;


        public EntityController(IEntity entityService)
        {
            _entityService = entityService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _entityService.GetAsync(id);
            return Ok(entity);
        }

        [HttpPost()]
        public async Task<IActionResult> Add([FromBody] Dtos.Post.Entity entity)
        {
            var addedEntity = await _entityService.AddAsync(entity);
            return Ok(addedEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Dtos.Put.Entity entity)
        {
            var updatedEntity = await _entityService.UpdateAsync(entity);
            return Ok(updatedEntity);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deletedEntity = await _entityService.DeleteAsync(id);
            return Ok(deletedEntity);
        }
    }
}
