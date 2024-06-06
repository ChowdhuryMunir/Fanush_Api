using Fanush.DAL.Interfaces;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.EmployeeManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : ControllerBase
    {
        private readonly IGenericRepository<JobTitle> _repository;

        public JobTitleController(IGenericRepository<JobTitle> repository)
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
        public async Task<ActionResult<JobTitle>> Get(int id)
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

        //[HttpPost]
        //public async Task<ActionResult> Post(Department department)
        //{
        //    var createdDepartment = await _repository.Post(department);
        //    return CreatedAtAction(nameof(Get), new { id = department.DepartmentId }, createdDepartment);
        //}

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