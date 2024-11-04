using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.User.Contracts;
using IConfiguration = SearchAndRescue.User.Contracts.Services.IConfiguration;

namespace SearchAndRescue.User.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogin _loginService;
        private readonly IConfiguration _configurationService;
        public UserController(ILogin loginService, IConfiguration configurationService)
        {
            _loginService = loginService;
            _configurationService = configurationService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Create(Dtos.Post.User register)
        {
            try
            {
                await _loginService.Register(register);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Signin([FromBody] Dtos.Get.LoginUser login)
        {
            try
            {
                var user = await _loginService.SignInAsync(login);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet("{id}/configuration")]
        public async Task<IActionResult> GetConfiguration(Guid id)
        {
            var config = _configurationService.GetAsync(id);
            return Ok(config);
        }

        [AllowAnonymous]
        [HttpPut("{id}/configuration")]
        public async Task<IActionResult> UpdateConfiguration(Guid id, [FromBody] Dtos.Post.Configuration configuration)
        {
            var success = _configurationService.UpdateAsync(id, configuration);
            return Ok(success);
        }


        [HttpPost("forgotpassword")]
        public IActionResult Reset()
        {
            return Ok();
        }
    }
}
