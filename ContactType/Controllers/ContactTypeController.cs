using Microsoft.AspNetCore.Mvc;
using IService = SearchAndRescue.ContactType.Contracts.Services.IContactType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SearchAndRescue.ContactType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactTypeController : ControllerBase
    {
        private readonly IService _service;

        public ContactTypeController(IService service)
        {
            _service = service;
        }

        // GET: api/<TemplateController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetContactTypesAsync());
        }

        // GET api/<TemplateController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Dtos.Get.ContactType contactType = new()
            {
                Id = id
            };
            return Ok(await _service.GetContactTypeAsync(contactType));
        }
    }
}
