using Microsoft.AspNetCore.Mvc;
using IService = SearchAndRescue.Favourite.Contracts.Services.IFavourite;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.Favourite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private readonly IService _service;

        public FavouriteController(IService service)
        {
            _service = service;
        }

        [HttpGet("entities")]
        public async Task<IActionResult> GetEntities()
        {
            return Ok(await _service.GetEntityFavouritesAsync());
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _service.GetProductFavouritesAsync());
        }

        [HttpGet("types")]
        public async Task<IActionResult> GetTypes()
        {
            return Ok(await _service.GetFavouriteTypesAsync());
        }

        // GET api/<FavouriteController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok();
        }

        // POST api/<FavouriteController>
        [HttpPost]
        public async void Post([FromBody] string value)
        {
        }

        // PUT api/<FavouriteController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FavouriteController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
        }
    }
}
