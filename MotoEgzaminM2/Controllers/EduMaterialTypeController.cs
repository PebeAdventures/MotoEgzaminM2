using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoEgzaminM2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EduMaterialTypeController : ControllerBase
    {

        private readonly IEduMaterialTypeService eduMaterialTypeService;

        public EduMaterialTypeController(IEduMaterialTypeService eduMaterialTypeService)
        {
            this.eduMaterialTypeService = eduMaterialTypeService;
        }

        // GET: api/<EduMaterialTypeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EduMaterialTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EduMaterialTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EduMaterialTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EduMaterialTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
