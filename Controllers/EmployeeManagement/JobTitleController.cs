using Fanush.DAL.Interfaces;
using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.EmployeeManagement
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class JobTitleController : ControllerBase
    {
        private readonly IJobTitleRepository _repository;

        public JobTitleController(IJobTitleRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTitle>>> Get()
        {
            var jobtitle = await _repository.Get();
            return Ok(jobtitle);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var jobtitle = await _repository.Get(id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            return Ok(jobtitle);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] JobTitle jobtitle)
        {
            var createdJobTitle = await _repository.Post(jobtitle);
            return CreatedAtAction(nameof(Get), new { id = jobtitle.JobTitleId }, createdJobTitle);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] JobTitle jobtitle)
        {
            if (id != jobtitle.JobTitleId)
            {
                return BadRequest();
            }
            var updatedJobTitle = await _repository.Put(id, jobtitle);
            return Ok(updatedJobTitle);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedJobTitle = await _repository.Delete(id);
            if (deletedJobTitle == null)
            {
                return NotFound();
            }
            return Ok(deletedJobTitle);
        }
    }
}