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
    public class EmployeeLifecycleController : ControllerBase
    {
        private readonly IEmployeeLifecycleRepository _repository;

        public EmployeeLifecycleController(IEmployeeLifecycleRepository repository)
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
        public async Task<ActionResult> Get(int id)
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
