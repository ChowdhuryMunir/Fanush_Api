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
    public class GoalController : ControllerBase
    {
        private readonly IGoalRepository _repository;

        public GoalController(IGoalRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Goal>>> Get()
        {
            var goals = await _repository.Get();
            return Ok(goals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var goal = await _repository.Get(id);
            if (goal == null)
            {
                return NotFound();
            }
            return Ok(goal);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Goal goal)
        {
            var createdGoal = await _repository.Post(goal);
            return CreatedAtAction(nameof(Get), new { id = goal.GoalId }, createdGoal);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Goal goal)
        {
            if (id != goal.GoalId)
            {
                return BadRequest();
            }
            var updatedGoal = await _repository.Put(id, goal);
            return Ok(updatedGoal);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedGoal = await _repository.Delete(id);
            if (deletedGoal == null)
            {
                return NotFound();
            }
            return Ok(deletedGoal);
        }
    }
}