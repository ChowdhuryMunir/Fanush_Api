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
    public class OvertimeController : ControllerBase
    {
        private readonly IOvertimeRepository _repository;

        public OvertimeController(IOvertimeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Overtime>>> Get()
        {
            var overtimes = await _repository.Get();
            return Ok(overtimes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var overtime = await _repository.Get(id);
            if (overtime == null)
            {
                return NotFound();
            }
            return Ok(overtime);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Overtime overtime)
        {
            var createdOvertime = await _repository.Post(overtime);
            return CreatedAtAction(nameof(Get), new { id = overtime.OvertimeId }, createdOvertime);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Overtime overtime)
        {
            if (id != overtime.OvertimeId)
            {
                return BadRequest();
            }
            var updatedOvertime = await _repository.Put(id, overtime);
            return Ok(updatedOvertime);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedOvertime = await _repository.Delete(id);
            if (deletedOvertime == null)
            {
                return NotFound();
            }
            return Ok(deletedOvertime);
        }
    }
}
