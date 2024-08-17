using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.TimeAndAttendanceController
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class AbsenceReportController : ControllerBase
    {
        private readonly IAbsenceReportRepository _repository;

        public AbsenceReportController(IAbsenceReportRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AbsenceReport>>> Get()
        {
            var absenceReports = await _repository.Get();
            return Ok(absenceReports);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var absenceReport = await _repository.Get(id);
            if (absenceReport == null)
            {
                return NotFound();
            }
            return Ok(absenceReport);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AbsenceReport absenceReport)
        {
            var createdAbsenceReport = await _repository.Post(absenceReport);
            return CreatedAtAction(nameof(Get), new { id = absenceReport.AbsenceReportId }, createdAbsenceReport);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AbsenceReport absenceReport)
        {
            if (id != absenceReport.AbsenceReportId)
            {
                return BadRequest();
            }
            var updatedAbsenceReport = await _repository.Put(id, absenceReport);
            return Ok(updatedAbsenceReport);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedAbsenceReport = await _repository.Delete(id);
            if (deletedAbsenceReport == null)
            {
                return NotFound();
            }
            return Ok(deletedAbsenceReport);
        }
    }
}
