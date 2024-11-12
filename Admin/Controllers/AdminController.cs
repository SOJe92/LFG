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
            return Ok(await _service.GetUsersAsync());
        }
    }
}
