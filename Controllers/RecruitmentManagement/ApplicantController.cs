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
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantRepository _repository;

        public ApplicantController(IApplicantRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> Get()
        {
            var applicants = await _repository.Get();
            return Ok(applicants);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var applicant = await _repository.Get(id);
            if (applicant == null)
            {
                return NotFound();
            }
            return Ok(applicant);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] Applicant applicant)
        {
            var createdApplicant = await _repository.Post(applicant);
            return CreatedAtAction(nameof(Get), new { id = applicant.ApplicantId }, createdApplicant);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromForm] Applicant applicant)
        {
            if (id != applicant.ApplicantId)
            {
                return BadRequest("Mismatched Applicant ID.");
            }

            var updatedApplicant = await _repository.Put(id, applicant);
            if (updatedApplicant == null)
            {
                return NotFound();
            }

            return Ok(updatedApplicant);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedApplicant = await _repository.Delete(id);
            if (deletedApplicant == null)
            {
                return NotFound();
            }
            return Ok(deletedApplicant);
        }
    }
}