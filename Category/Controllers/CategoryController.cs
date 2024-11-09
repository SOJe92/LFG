using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.Category.Contracts.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }


        // GET: api/<TemplateController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _category.GetCategoriesAsync());
        }

        // GET api/<TemplateController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return NotFound();
        }
    }
}
