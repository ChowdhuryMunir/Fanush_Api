using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.Entities.PerformenceManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fanush.Controllers.PerformenceManagement
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class PerformanceReportController : ControllerBase
    {
        private readonly IPerformanceReportRepository _repository;

        public PerformanceReportController(IPerformanceReportRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerformanceReport>>> Get()
        {
            var reports = await _repository.Get();
            return Ok(reports);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var report = await _repository.Get(id);
            if (report == null)
            {
                return NotFound();
            }
            return Ok(report);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PerformanceReport report)
        {
            var createdReport = await _repository.Post(report);
            return CreatedAtAction(nameof(Get), new { id = report.PerformanceReportId }, createdReport);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PerformanceReport report)
        {
            if (id != report.PerformanceReportId)
            {
                return BadRequest();
            }
            var updatedReport = await _repository.Put(id, report);
            return Ok(updatedReport);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedReport = await _repository.Delete(id);
            if (deletedReport == null)
            {
                return NotFound();
            }
            return Ok(deletedReport);
        }
    }
}