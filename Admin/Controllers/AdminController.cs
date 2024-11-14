using Microsoft.AspNetCore.Mvc;
using IService = SearchAndRescue.Admin.Contracts.Services.IAdmin;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IService _service;

        public AdminController(IService service)
        {
            _service = service;
        }

        // GET: api/<TemplateController>
        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _service.GetUsersAsync();
            return Ok(result);
        }

        // GET: api/<TemplateController>
        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var result = await _service.GetUserAsync(id);
            return Ok(result);
        }
    }
}
