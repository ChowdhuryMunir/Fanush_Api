using Fanush.DAL.Interfaces;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.EmployeeManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeLifecycleController : ControllerBase
    {
        private readonly IGenericRepository<EmployeeLifecycle> _repository;

        public EmployeeLifecycleController(IGenericRepository<EmployeeLifecycle> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeLifecycle>>> Get()
        {
            var employeelifecycles = await _repository.Get();
            return Ok(employeelifecycles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeLifecycle>> Get(int id)
        {
            var employeelifecycle = await _repository.Get(id);
            if (employeelifecycle == null)
            {
                return NotFound();

            }
            return Ok(employeelifecycle);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeeLifecycle employeelifecycle)
        {
            var createdEmployeeLifecycle = await _repository.Post(employeelifecycle);
            return CreatedAtAction(nameof(Get), new { id = employeelifecycle.LifecycleId }, createdEmployeeLifecycle);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeeLifecycle employeelifecycle)
        {
            if (id != employeelifecycle.LifecycleId)
            {
                return BadRequest();
            }
            var updatedEmployeeLifecycle = await _repository.Put(id, employeelifecycle);
            return Ok(updatedEmployeeLifecycle);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedEmployeeLifecycle = await _repository.Delete(id);
            if (deletedEmployeeLifecycle == null)
            {
                return NotFound();
            }
            return Ok(Get());
        }
    }
}
