using Fanush.DAL.Interfaces;
using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.EmployeeManagement
{
    [Route("api/Department")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class DepartmentController : ControllerBase
    {
        public IDepartmentRepository _repository;

        public DepartmentController(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetDepartments")]
        
        public async Task<IActionResult> Get()
        {
            var departments = await _repository.Get();
            return Ok(departments);
        }

        [HttpGet, Route("GetDepartment/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var department = await _repository.Get(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        //[HttpPost]
        //public async Task<ActionResult> Post([FromBody] Department department)
        //{
        //    var createdDepartment = await _repository.Post(department);
        //    return CreatedAtAction(nameof(Get), new { id = department.DepartmentId }, createdDepartment);
        //}

        [HttpPost, Route("InsertDept")]
        public async Task<ActionResult> Post([FromForm] Department  department)
        {
            var createdDepartment = await _repository.Post(department);
            return CreatedAtAction(nameof(Get), new { id = department.DepartmentId }, createdDepartment);
        }

        [HttpPut, Route("UpdateDept/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Department department)
        {
            if (id != department.DepartmentId)
            {
                return BadRequest();
            }
            var updatedDepartment = await _repository.Put(id, department);
            return Ok(updatedDepartment);
        }

        [HttpDelete, Route("DeleteDept/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedDepartment = await _repository.Delete(id);
            if (deletedDepartment == null)
            {
                return NotFound();
            }
            return Ok(deletedDepartment);
        }
    }
}
