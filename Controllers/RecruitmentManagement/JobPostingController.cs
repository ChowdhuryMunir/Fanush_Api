using Fanush.DAL.Interfaces.RecruitmentInterface;
using Fanush.Entities.RecruitmentManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.RecruitmentManagement
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class JobPostingController : ControllerBase
    {
        private readonly IJobPostingRepository _repository;

        public JobPostingController(IJobPostingRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("GetAllJobPosting")]
        public async Task<ActionResult<IEnumerable<JobPosting>>> Get()
        {
            var jobPostings = await _repository.Get();
            return Ok(jobPostings);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var jobPosting = await _repository.Get(id);
            if (jobPosting == null)
            {
                return NotFound();
            }
            return Ok(jobPosting);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] JobPosting jobPosting)
        {
            var createdJobPosting = await _repository.Post(jobPosting);
            return CreatedAtAction(nameof(Get), new { id = jobPosting.JobPostingId }, createdJobPosting);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] JobPosting jobPosting)
        {
            if (id != jobPosting.JobPostingId)
            {
                return BadRequest();
            }
            var updatedJobPosting = await _repository.Put(id, jobPosting);
            return Ok(updatedJobPosting);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedJobPosting = await _repository.Delete(id);
            if (deletedJobPosting == null)
            {
                return NotFound();
            }
            return Ok(deletedJobPosting);
        }
    }
}