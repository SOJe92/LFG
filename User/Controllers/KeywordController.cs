using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.User.Controllers
{
    [Route("api/user/{userId}/keyword")]
    [ApiController]
    public class UserKeywordController : ControllerBase
    {
        // GET: api/<KeywordController>
        [HttpGet]
        public async Task<IActionResult> Get(Guid userId)
        {
            return Ok();
        }

        // GET api/<KeywordController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid userId, Guid id)
        {
            return Ok();
        }

        // POST api/<KeywordController>
        [HttpPost]
        public async Task<IActionResult> Post(Guid userId, [FromBody] Dtos.Get.Keyword keyword)
        {
            return Ok();
        }

        // DELETE api/<KeywordController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid userId, Guid id)
        {
            return Ok();
        }
    }
}
