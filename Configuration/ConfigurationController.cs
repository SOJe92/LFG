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
            Dtos.Get.Configuration configuration = new();

            configuration.Sectors = await _configuration.GetSectors();

            return Ok(configuration);
        }
    }
}
