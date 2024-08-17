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
    public class PayrollIntegrationController : ControllerBase
    {
        private readonly IPayrollIntegrationRepository _repository;

        public PayrollIntegrationController(IPayrollIntegrationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayrollIntegration>>> Get()
        {
            var payrollIntegrations = await _repository.Get();
            return Ok(payrollIntegrations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var payrollIntegration = await _repository.Get(id);
            if (payrollIntegration == null)
            {
                return NotFound();
            }
            return Ok(payrollIntegration);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PayrollIntegration payrollIntegration)
        {
            var createdPayrollIntegration = await _repository.Post(payrollIntegration);
            return CreatedAtAction(nameof(Get), new { id = payrollIntegration.PayrollIntegrationId }, createdPayrollIntegration);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] PayrollIntegration payrollIntegration)
        {
            if (id != payrollIntegration.PayrollIntegrationId)
            {
                return BadRequest();
            }
            var updatedPayrollIntegration = await _repository.Put(id, payrollIntegration);
            return Ok(updatedPayrollIntegration);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedPayrollIntegration = await _repository.Delete(id);
            if (deletedPayrollIntegration == null)
            {
                return NotFound();
            }
            return Ok(deletedPayrollIntegration);
        }
    }
}
