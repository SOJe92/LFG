﻿using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.Entities.Contracts.Services;

namespace SearchAndRescue.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private readonly IEntities _entitiesService;


        public EntitiesController(IEntities entitiesService)
        {
            _entitiesService = entitiesService;
        }

        [HttpGet("entity")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _entitiesService.Get(id);
            return Ok(entity);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll(Guid userId)
        {
            var entities = await _entitiesService.GetAll(userId);
            return Ok(entities);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Dtos.Post.Entity entity)
        {
            var addedEntity = await _entitiesService.Add(entity);
            return Ok(addedEntity);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] Dtos.Put.Entity entity)
        {
            var updatedEntity = await _entitiesService.Update(entity);
            return Ok(updatedEntity);
        }
    }
}
