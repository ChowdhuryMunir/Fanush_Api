using Fanush.DAL.Interfaces;
using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Fanush.Controllers.EmployeeController
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            var employees = await _repository.Get();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var employee = await _repository.Get(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Employee employee)
        {
            var createdEmployee = await _repository.Post(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.EmployeeId }, createdEmployee);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }
            var updatedEmployee = await _repository.Put(id, employee);
            return Ok(updatedEmployee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedEmployee = await _repository.Delete(id);
            if (deletedEmployee == null)
            {
                return NotFound();
            }
            return Ok(deletedEmployee);
        }

        [HttpGet("count/total")]
        public async Task<ActionResult<int>> CountTotalEmployees()
        {
            var count = await _repository.CountTotalEmployees();
            return Ok(count);
        }

        [HttpGet("count/active")]
        public async Task<ActionResult<int>> CountActiveEmployees()
        {
            var count = await _repository.CountActiveEmployees();
            return Ok(count);
        }

        [HttpGet("count/inactive")]
        public async Task<ActionResult<int>> CountInactiveEmployees()
        {
            var count = await _repository.CountInactiveEmployees();
            return Ok(count);
        }

        [HttpGet("count/department")]
        public async Task<ActionResult<Dictionary<string, int>>> CountEmployeesByDepartment()
        {
            var count = await _repository.CountEmployeesByDepartment();
            return Ok(count);
        }

        [HttpGet("attendance/today")]
        public async Task<ActionResult<int>> CountTodayAttendance()
        {
            var count = await _repository.CountTodayAttendance();
            return Ok(count);
        }

        [HttpGet("absent-today")]
        public async Task<ActionResult<int>> GetTodayAbsentCount()
        {
            var absentCount = await _repository.CountTodayAbsentEmployees();
            return Ok(absentCount);
        }

        [HttpGet("attendance/weekly")]
        public async Task<ActionResult<int>> CountWeeklyAttendance()
        {
            var count = await _repository.CountWeeklyAttendance();
            return Ok(count);
        }

        [HttpGet("attendance/monthly")]
        public async Task<ActionResult<int>> CountMonthlyAttendance()
        {
            var count = await _repository.CountMonthlyAttendance();
            return Ok(count);
        }

        [HttpGet("leave")]
        public async Task<ActionResult<int>> CountEmployeesOnLeave()
        {
            var count = await _repository.CountEmployeesOnLeave();
            return Ok(count);
        }
    }
}

