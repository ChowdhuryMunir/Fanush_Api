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
    public class DevelopmentPlanController : ControllerBase
    {
        private readonly IDevelopmentPlanRepository _repository;

        public DevelopmentPlanController(IDevelopmentPlanRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DevelopmentPlan>>> Get()
        {
            var plans = await _repository.Get();
            return Ok(plans);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var plan = await _repository.Get(id);
            if (plan == null)
            {
                return NotFound();
            }
            return Ok(plan);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DevelopmentPlan plan)
        {
            var createdPlan = await _repository.Post(plan);
            return CreatedAtAction(nameof(Get), new { id = plan.DevelopmentPlanId }, createdPlan);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DevelopmentPlan plan)
        {
            if (id != plan.DevelopmentPlanId)
            {
                return BadRequest("ID mismatch between route and body.");
            }

            var updatedPlan = await _repository.Put(id, plan);

            if (updatedPlan is string)
            {
                return NotFound(updatedPlan);
            }

            return Ok(updatedPlan);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedPlan = await _repository.Delete(id);
            if (deletedPlan == null)
            {
                return NotFound();
            }
            return Ok(deletedPlan);
        }
    }
}
