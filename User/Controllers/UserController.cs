using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.User.Contracts;
using IConfiguration = SearchAndRescue.User.Contracts.Services.IConfiguration;
using IService = SearchAndRescue.User.Contracts.Services.IUser;

namespace SearchAndRescue.User.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogin _loginService;
        private readonly IConfiguration _configurationService;
        private readonly IService _service;
        public UserController(ILogin loginService, IConfiguration configurationService, IService service)
        {
            _loginService = loginService;
            _configurationService = configurationService;
            _service = service;
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
        public async Task<IActionResult> Signin([FromBody] Dtos.Post.User login)
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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Dtos.Get.ChildUser user)
        {
            var config = await _service.GetUserAsync(user);
            return Ok(config);
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
