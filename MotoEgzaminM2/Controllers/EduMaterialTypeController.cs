using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.DTO.EduMaterialType;
using MotoEgzaminM2.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoEgzaminM2.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/Types")]
    [ApiController]
    public class EduMaterialTypeController : ControllerBase
    {

        private readonly IEduMaterialTypeService eduMaterialTypeService;

        public EduMaterialTypeController(IEduMaterialTypeService eduMaterialTypeService)
        {
            this.eduMaterialTypeService = eduMaterialTypeService;
        }

        // GET: api/<EduMaterialTypeController>
        [HttpGet, Authorize(Roles = "User")]
        public async Task<ActionResult<List<EduMaterialTypeDTO>>> Get(string? name)
        {
            if (name != null)
            {
                return Ok(await eduMaterialTypeService.findByName(name));
            }

            return Ok(await eduMaterialTypeService.findAll());
        }



    }
}
