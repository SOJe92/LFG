using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.Search.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.Search.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;

        public SearchController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        // GET api/<SearchController>/5
        [HttpGet("{category}")]
        public async Task<IActionResult> Get(string category)
        {
            object? results = SearchServiceFactory.ExecuteSearch(category, _serviceProvider);

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }
    }
}
