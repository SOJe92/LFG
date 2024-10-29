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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid userId)
        {
            var entity = await _entitiesService.Get(userId);
            return Ok(entity);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entity = await _entitiesService.Get();
            return Ok(entity);
        }
    }
}
