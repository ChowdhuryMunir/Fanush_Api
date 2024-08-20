using Fanush.DAL.Interfaces.PayrollInterface;
using Fanush.Entities.PayrollManagement;
using Fanush.Entities.TimeAndAttendence;
using Fanush.Repositories.PayrollManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Fanush.Controllers.PayrollManagement
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class PayrollCalculationController : ControllerBase
    {
        private readonly IPayrollCalculationRepository _repository;

        public PayrollCalculationController(IPayrollCalculationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PayrollCalculation>>> GetPayrollCalculations()
        {
            var payrollCalculations = await _repository.GetAllPayrollCalculationsAsync();
            return Ok(payrollCalculations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PayrollCalculation>> GetPayrollCalculation(int id)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }
            return Ok(payrollCalculation);
        }

        [HttpPost]
        public async Task<ActionResult<PayrollCalculation>> CreatePayrollCalculation(PayrollCalculation payrollCalculation)
        {
            var createdPayrollCalculation = await _repository.AddPayrollCalculationAsync(payrollCalculation);
            return CreatedAtAction(nameof(GetPayrollCalculation), new { id = createdPayrollCalculation.PayrollCalcuationId }, createdPayrollCalculation);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePayrollCalculation(int id, PayrollCalculation payrollCalculation)
        {
            if (id != payrollCalculation.PayrollCalcuationId)
            {
                return BadRequest();
            }

            await _repository.UpdatePayrollCalculationAsync(payrollCalculation);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePayrollCalculation(int id)
        {
            var result = await _repository.DeletePayrollCalculationAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpPost("{id}/payslip")]
        public async Task<ActionResult<string>> GeneratePaySlip(int id, [FromBody] PaySlipRequestModel model)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            // Assuming `model` contains the required data for overtime, absence report, leaves, and pay date
            string paySlipDetails = payrollCalculation.GeneratePaySlip(model.Overtimes, model.AbsenceReport, model.Leaves, model.PayDate);
            return Ok(paySlipDetails);
        }
    }
    public class PaySlipRequestModel
    {
        public List<Overtime> Overtimes { get; set; }
        public AbsenceReport AbsenceReport { get; set; }
        public List<Leave> Leaves { get; set; }
        public DateTime PayDate { get; set; }
    }
}
