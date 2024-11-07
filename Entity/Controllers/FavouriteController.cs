using Microsoft.AspNetCore.Mvc;
using IService = SearchAndRescue.Favourite.Contracts.Services.IFavourite;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.Entity.Controllers
{
    [Route("api/entity/{entityId}/favourite")]
    [ApiController]
    public class EntityFavouriteController : ControllerBase
    {
        private readonly IService _service;
        private readonly Guid _type;

        public EntityFavouriteController(IService service)
        {
            _service = service;
            _type = _service.GetFavouriteTypes().First((favType) => favType.Name == "entity").Id;
        }

        [HttpPost("{userid}")]
        public async Task<IActionResult> Add(Guid entityId, Guid userId)
        {
            Favourite.Dtos.Post.UserFavourite entity = new()
            {
                UserId = userId,
                ResourceId = entityId,
                TypeId = _type
            };
            return Ok(await _service.AddEntityFavouriteAsync(entity));
        }

        // GET: api/<FavouriteController>
        [HttpGet]
        public async Task<IActionResult> Get(Guid entityId)
        {
            return Ok(await _service.GetEntityFavouritesAsync());
        }

        // GET api/<FavouriteController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid entityId, Guid id)
        {
            Favourite.Dtos.Get.EntityFavourite entity = new()
            {
                Id = id,
                EntityId = entityId
                
            };
            return Ok(await _service.GetEntityFavouriteAsync(entity));
        }

        // DELETE api/<FavouriteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid entityId, Guid id)
        {
            Favourite.Dtos.Get.EntityFavourite entity = new()
            {
                Id = id,
                EntityId = entityId
            };
            return Ok(await _service.DeleteEntityFavouriteAsync(entity));
        }
    }
}
