using Microsoft.AspNetCore.Mvc;

namespace SearchAndRescue.Configuration
{
    [Route("[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        private readonly Contracts.Services.IConfiguration _configuration;

        public ConfigurationController(Contracts.Services.IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Dtos.Get.Configuration configuration = await _configuration.GetAsync();

            return Ok(configuration);
        }
    }
}
