using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.ContactType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactTypeController : ControllerBase
    {
        // GET: api/<TemplateController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return NotFound();
        }

        // GET api/<TemplateController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return NotFound();
        }

        // POST api/<TemplateController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return NotFound();

        }

        // PUT api/<TemplateController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
            return NotFound();
        }

        // DELETE api/<TemplateController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return NotFound();
        }
    }
}
