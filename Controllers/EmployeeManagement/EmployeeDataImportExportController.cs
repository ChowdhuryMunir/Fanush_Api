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
    public class EmployeeDataImportExportController : ControllerBase
    {
        private readonly IEmployeeDataImportExportRepository _repository;

        public EmployeeDataImportExportController(IEmployeeDataImportExportRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDataImportExport>>> Get()
        {
            var employeedataimportexport = await _repository.Get();
            return Ok(employeedataimportexport);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var employeedataimportexport = await _repository.Get(id);
            if (employeedataimportexport == null)
            {
                return NotFound();
            }
            return Ok(employeedataimportexport);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmployeeDataImportExport employeedataimportexport)
        {
            var createdEmployeeDataImportExport = await _repository.Post(employeedataimportexport);
            return CreatedAtAction(nameof(Get), new { id = employeedataimportexport.ImportExportId }, createdEmployeeDataImportExport);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployeeDataImportExport employeedataimportexport)
        {
            if (id != employeedataimportexport.ImportExportId)
            {
                return BadRequest();
            }
            var updatedEmployeeDataImportExport = await _repository.Put(id, employeedataimportexport);
            return Ok(updatedEmployeeDataImportExport);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedEmployeeDataImportExport = await _repository.Delete(id);
            if (deletedEmployeeDataImportExport == null)
            {
                return NotFound();
            }
            return Ok(deletedEmployeeDataImportExport);
        }
    }
}
