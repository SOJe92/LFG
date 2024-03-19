using Microsoft.AspNetCore.Mvc;
using SearchAndRescue.User.Contracts;
using SearchAndRescue.User.Dtos.Get;

namespace SearchAndRescue.External.Controllers
{

    [Route("[controller]")]
    public class OAuthController : ControllerBase
    {
        private readonly ILogin _loginService;

        public OAuthController(ILogin loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User.Dtos.Post.User registration)
        {
            LoginUser login = await _loginService.Authenticate(registration);
            return Ok(login);
        }
    }
}
