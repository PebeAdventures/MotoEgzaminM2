using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.DTO.EduMaterialReview;
using MotoEgzaminM2.Services.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoEgzaminM2.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/Reviews")]
    [ApiController]
    public class EduMaterialReviewController : ControllerBase
    {
        private readonly IEduMaterialReviewService eduMaterialReviewService;

        public EduMaterialReviewController(IEduMaterialReviewService eduMaterialReviewService)
        {
            this.eduMaterialReviewService = eduMaterialReviewService;
        }


        // GET: api/<EdumaterialReviewController>
        [SwaggerOperation(Summary = "Get all material reviews")]
        [HttpGet, Authorize(Roles = "Admin,User")]
        public async Task<ActionResult<IEnumerable<EduMaterialReviewReadDTO>>> GetAllReviews()
        {

            var reviews = await eduMaterialReviewService.GetAllReviews();

            return Ok(reviews);
        }



        // POST api/<EdumaterialReviewController>
        [SwaggerOperation(Summary = "Add new review to selected material")]
        [HttpPost("{id}"), Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> AddNewReview(int id, [FromBody] EduMaterialReviewCreateDTO reviewCreateDTO)
        {
            await eduMaterialReviewService.CreateReview(id, reviewCreateDTO);
            return NoContent();
        }

        // PUT api/<EdumaterialReviewController>/5
        [SwaggerOperation(Summary = "Edit specified Review")]
        [HttpPut("{id}"), Authorize(Roles = "Admin,User")]
        public async Task<IActionResult> EditReview(int id, [FromBody] EduMaterialReviewUpdateDTO reviewUpdateDTO)
        {
            await eduMaterialReviewService.EditReview(id, reviewUpdateDTO);
            return NoContent();

        }

        // DELETE api/<EdumaterialReviewController>/5
        [SwaggerOperation(Summary = "Delete specific review")]
        [HttpDelete("{id}"), Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await eduMaterialReviewService.DeleteReview(id);
            return NoContent();
        }
    }
}
