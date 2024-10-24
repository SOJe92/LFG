using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("entity/{id}")]
        public async Task<IActionResult> Get(Guid userId)
        {
            var entity = await _entitiesService.Get(userId);
            return Ok(entity);
        }

        [HttpGet("entity")]
        public async Task<IActionResult> GetAll()
        {
            var entity = await _entitiesService.GetAll();
            return Ok(entity);
        }
    }
}
