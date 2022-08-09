using Microsoft.AspNetCore.Mvc;
using MotoEgzaminM2.DTO.EduMaterialReview;
using MotoEgzaminM2.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotoEgzaminM2.Controllers
{
    [Route("api/Reviews")]
    [ApiController]
    public class EduMaterialReviewController : ControllerBase
    {
        private readonly IEduMaterialReviewService eduMaterialReviewService;

        public EduMaterialReviewController(IEduMaterialReviewService eduMaterialReviewService)
        {
            this.eduMaterialReviewService = eduMaterialReviewService;
        }

        //ADMIN
        //USER
        // GET: api/<EdumaterialReviewController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EduMaterialReviewReadDTO>>> GetAllReviews()
        {
            var reviews = await eduMaterialReviewService.GetAllReviews();

            return Ok(reviews);
        }

        // GET api/<EdumaterialReviewController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //ADMIN
        //USER
        // POST api/<EdumaterialReviewController>
        //Create new Review
        [HttpPost]
        public async Task<IActionResult> AddNewReview([FromBody] EduMaterialReviewCreateDTO reviewCreateDTO)
        {
            await eduMaterialReviewService.CreateReview(reviewCreateDTO);
            return NoContent();
        }
        //ADMIN
        //USER
        // PUT api/<EdumaterialReviewController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditReview(int id, [FromBody] EduMaterialReviewUpdateDTO reviewUpdateDTO)
        {
            await eduMaterialReviewService.EditReview(id, reviewUpdateDTO);
            return NoContent();

        }
        //ADMIN
        // DELETE api/<EdumaterialReviewController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await eduMaterialReviewService.DeleteReview(id);
            return NoContent();
        }
    }
}
