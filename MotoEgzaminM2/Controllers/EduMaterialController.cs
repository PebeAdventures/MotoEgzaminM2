using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.DTO.EduMaterial;
using MotoEgzaminM2.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoEgzaminM2.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/Materials")]
    [ApiController]
    public class EduMaterialController : ControllerBase
    {
        private readonly IEduMaterialService eduMaterialService;

        public EduMaterialController(IEduMaterialService eduMaterialService)
        {
            this.eduMaterialService = eduMaterialService;
        }


        //USER
        //ADMIN
        // GET: api/<EduMaterialController>
        [SwaggerOperation(Summary = "Get all materials")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EduMaterialReadDTO>>> GetAllMaterials()
        {
            var materials = await eduMaterialService.GetAllmaterials();

            return Ok(materials);
        }

        //ADMIN
        // GET api/Authors/{id}/Materials"
        [SwaggerOperation(Summary = "Get materials from specific author, with material rate 5+")]
        [HttpGet("Authors/{id}/getWithRateGreaterThan5")]
        public async Task<ActionResult<IEnumerable<EduMaterialWithRatedAuthorReadDTO>>> GetMaterialByAuthorWithRate(int id)
        {
            var reviews = await eduMaterialService.GetAllMaterialsFromAuthorWithScoreAbove5(id);


            return Ok(reviews);
        }

        //ADMIN
        // GET api/Types/{id}/Materials"
        [SwaggerOperation(Summary = "Get all materials from specific type")]
        [HttpGet("Type/{id}")]
        public async Task<ActionResult<IEnumerable<EduMaterialReadDTO>>> GetMaterialsByType(int id)
        {
            var reviews = await eduMaterialService.GetAllMaterialsFromType(id);


            return Ok(reviews);
        }

        //ADMIN
        // PUT api/<EduMaterialController>/5
        [SwaggerOperation(Summary = "Update selected material")]
        [HttpPut("{id}")]
        public async Task<IActionResult> EditMaterial(int id, [FromBody] EduMaterialUpdateDTO materialUpdateDTO)
        {
            await eduMaterialService.EditMaterial(id, materialUpdateDTO);
            return NoContent();

        }

        //ADMIN
        // POST api/<EduMaterialController>
        [SwaggerOperation(Summary = "Create new material")]
        [HttpPost]
        public async Task<IActionResult> CreateMaterial([FromBody] EduMaterialCreateDTO createDTO)
        {
            await eduMaterialService.CreateMaterial(createDTO);
            return NoContent();
        }

        // DELETE api/<EduMaterialController>/5
        [SwaggerOperation(Summary = "Delete material")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterial(int id)
        {
            await eduMaterialService.DeleteMaterial(id);
            return NoContent();
        }
    }
}
