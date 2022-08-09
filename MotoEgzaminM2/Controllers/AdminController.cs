using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.DTO.Admin;
using MotoEgzaminM2.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace MotoEgzaminM2.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/Admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IAdminService Service;

        public AdminController(IAdminService service)
        {
            Service = service;
        }

        [SwaggerOperation(Summary = "Register a new Admin")]
        [HttpPost, Authorize(Roles = "Admin")]
        public async Task<ActionResult> RegisterNewAdmin([FromBody] AdminCreateDTO request)
        {
            try
            {
                var result = await Service.AddNewAdmin(request);
                return Ok(result.id);
            }
            catch (Exception e)
            {
                return new BadRequestResult();
            }
        }
    }
}
