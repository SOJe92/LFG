using Microsoft.AspNetCore.Mvc;
using IService = SearchAndRescue.Products.Contracts.Services.IProducts;

namespace SearchAndRescue.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IService _service;

        public ProductsController(IService service) => _service = service;

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAsync());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _service.GetAsync(id));
        }
    }
}
