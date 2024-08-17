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
    public class InterviewController : ControllerBase
    {
        private readonly IInterviewRepository _repository;

        public InterviewController(IInterviewRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Interview>>> Get()
        {
            var interviews = await _repository.Get();
            return Ok(interviews);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var interview = await _repository.Get(id);
            if (interview == null)
            {
                return NotFound();
            }
            return Ok(interview);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Interview interview)
        {
            var createdInterview = await _repository.Post(interview);
            return CreatedAtAction(nameof(Get), new { id = interview.InterviewId }, createdInterview);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Interview interview)
        {
            if (id != interview.InterviewId)
            {
                return BadRequest();
            }
            var updatedInterview = await _repository.Put(id, interview);
            return Ok(updatedInterview);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedInterview = await _repository.Delete(id);
            if (deletedInterview == null)
            {
                return NotFound();
            }
            return Ok(deletedInterview);
        }
    }
}
