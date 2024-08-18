using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.Entities.PerformenceManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.PerformenceManagement
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class PerformanceReviewController : ControllerBase
    {
        private readonly IPerformanceReviewRepository _repository;

        public PerformanceReviewController(IPerformanceReviewRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerformanceReview>>> Get()
        {
            var reviews = await _repository.Get();
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var review = await _repository.Get(id);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PerformanceReview review)
        {
            var createdReview = await _repository.Post(review);
            return CreatedAtAction(nameof(Get), new { id = review.PerformanceReviewId }, createdReview);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PerformanceReview review)
        {
            if (id != review.PerformanceReviewId)
            {
                return BadRequest();
            }
            var updatedReview = await _repository.Put(id, review);
            return Ok(updatedReview);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedReview = await _repository.Delete(id);
            if (deletedReview == null)
            {
                return NotFound();
            }
            return Ok(deletedReview);
        }
    }
}