using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.User.Contracts;
using SearchAndRescue.User.Dtos.Post;

namespace SearchAndRescue.User.Controllers
{
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogin _loginService;
        public UserController(ILogin loginService)
        {
            _loginService = loginService;
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

        [HttpPost("forgotpassword")]
        public IActionResult Reset()
        {
            return Ok();
        }
    }
}
