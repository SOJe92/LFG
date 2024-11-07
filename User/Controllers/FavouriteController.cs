using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.Favourite.Contracts.Services;
using IService = SearchAndRescue.User.Contracts.Services.IUser;

namespace SearchAndRescue.User.Controllers
{
    [Route("api/user/{userId}/favourite")]
    [ApiController]
    public class UserFavouriteController : ControllerBase
    {
        private readonly IService _service;
        private readonly IFavourite _favourite;

        public UserFavouriteController(IService service, IFavourite favourite)
        {
            _service = service;
            _favourite = favourite;
        }

        // GET: api/<FavouriteController>
        [HttpGet]
        public async Task<IActionResult> Get(Guid userId, Guid typeId)
        {

            Favourite.Dtos.Get.FavouriteType type = await _favourite.GetFavouriteTypeAsync(new Favourite.Dtos.Get.FavouriteType() { Id = typeId });
            return type.Name switch
            {
                "entity" => Ok(await _service.GetFavouriteEntitiesAsync(userId)),
                "product" => Ok(await _service.GetFavouriteProductsAsync(userId)),
                _ => BadRequest(),
            };
        }

        // GET api/<FavouriteController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid userId, Guid resourceId, Guid typeId)
        {
            Favourite.Dtos.Get.FavouriteType type = await _favourite.GetFavouriteTypeAsync(new Favourite.Dtos.Get.FavouriteType() { Id = typeId });
            Dtos.Get.Favourite favourite = new()
            {
                ResourceId = resourceId,
                UserId = userId,
                TypeId = typeId
            };
            return type.Name switch
            {
                "entity" => Ok(await _service.GetFavouriteEntityAsync(favourite)),
                "product" => Ok(await _service.GetFavouriteProductAsync(favourite)),
                _ => BadRequest(),
            };
        }

        // DELETE api/<FavouriteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid userId, Guid id, Guid typeId)
        {
            Favourite.Dtos.Get.FavouriteType type = await _favourite.GetFavouriteTypeAsync(new Favourite.Dtos.Get.FavouriteType() { Id = typeId });
            return type.Name switch
            {
                "entity" => Ok(await _service.DeleteFavouriteEntityAsync(id)),
                "product" => Ok(await _service.DeleteFavouriteProductAsync(id)),
                _ => BadRequest(),
            };
        }
    }
}
