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
    public class ClockInOutController : ControllerBase
    {
        private readonly IClockInOutRepository _repository;

        public ClockInOutController(IClockInOutRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClockInOut>>> Get()
        {
            var clockInOuts = await _repository.Get();
            return Ok(clockInOuts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var clockInOut = await _repository.Get(id);
            if (clockInOut == null)
            {
                return NotFound();
            }
            return Ok(clockInOut);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClockInOut clockInOut)
        {
            var createdClockInOut = await _repository.Post(clockInOut);
            return CreatedAtAction(nameof(Get), new { id = clockInOut.ClockInOutId }, createdClockInOut);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClockInOut clockInOut)
        {
            if (id != clockInOut.ClockInOutId)
            {
                return BadRequest("Mismatched id in route parameter and entity body.");
            }

            try
            {
                var updatedClockInOut = await _repository.Put(id, clockInOut);
                return Ok(updatedClockInOut);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to update ClockInOut record: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedClockInOut = await _repository.Delete(id);
            if (deletedClockInOut == null)
            {
                return NotFound("ClockInOut record not found.");
            }
            return Ok(deletedClockInOut);
        }
    }
}
