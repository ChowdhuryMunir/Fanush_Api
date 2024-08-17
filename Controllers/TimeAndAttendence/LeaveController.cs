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
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveRepository _repository;

        public LeaveController(ILeaveRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Leave>>> Get()
        {
            var leaves = await _repository.Get();
            return Ok(leaves);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var leave = await _repository.Get(id);
            if (leave == null)
            {
                return NotFound();
            }
            return Ok(leave);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Leave leave)
        {
            var createdLeave = await _repository.Post(leave);
            return CreatedAtAction(nameof(Get), new { id = leave.LeaveId }, createdLeave);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Leave leave)
        {
            if (id != leave.LeaveId)
            {
                return BadRequest();
            }
            var updatedLeave = await _repository.Put(id, leave);
            return Ok(updatedLeave);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedLeave = await _repository.Delete(id);
            if (deletedLeave == null)
            {
                return NotFound();
            }
            return Ok(deletedLeave);
        }
    }
}
