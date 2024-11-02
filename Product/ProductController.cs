using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.Product.Contracts.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.Product
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _productService;

        public ProductController(IProduct productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var product = await _productService.Get(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Dtos.Post.Product product)
        {
            var addedProduct = await _productService.Add(product);
            return Ok(addedProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] Dtos.Put.Product product)
        {
            var updatedProduct = await _productService.Update(product);
            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deletedProduct = await _productService.Delete(id);
            return Ok(deletedProduct);
        }
    }
}
