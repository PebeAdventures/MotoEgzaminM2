using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.DTO.Author;
using MotoEgzaminM2.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoEgzaminM2.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/Authors")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }
        //

        //USER
        //ADMIN
        // GET: api/<AuthorController>
        [SwaggerOperation(Summary = "Get all Authors with his material list")]
        [HttpGet, Authorize(Roles = "Admin,User")]
        public async Task<ActionResult<IEnumerable<AuthorReadDTO>>> GetAllAuthors()
        {
            var authors = await authorService.GetAllAuthors();
            return Ok(authors);
        }



    }
}
