//using Fanush.DAL.Interfaces.PayrollInterface;
//using Fanush.Entities.PayrollManagement;
//using Fanush.Entities.TimeAndAttendence;
//using Fanush.Repositories.PayrollManagement;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Cors;

//namespace Fanush.Controllers.PayrollManagement
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    [EnableCors("AllowOrigin")]
//    [AllowAnonymous]
//    public class PayrollCalculationController : ControllerBase
//    {
//        private readonly IPayrollCalculationRepository _repository;

//        public PayrollCalculationController(IPayrollCalculationRepository repository)
//        {
//            _repository = repository;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<PayrollCalculation>>> GetPayrollCalculations()
//        {
//            var payrollCalculations = await _repository.GetAllPayrollCalculationsAsync();
//            return Ok(payrollCalculations);
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<PayrollCalculation>> GetPayrollCalculation(int id)
//        {
//            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
//            if (payrollCalculation == null)
//            {
//                return NotFound();
//            }
//            return Ok(payrollCalculation);
//        }

//        [HttpPost]
//        public async Task<ActionResult<PayrollCalculation>> CreatePayrollCalculation(PayrollCalculation payrollCalculation)
//        {
//            var createdPayrollCalculation = await _repository.AddPayrollCalculationAsync(payrollCalculation);
//            return CreatedAtAction(nameof(GetPayrollCalculation), new { id = createdPayrollCalculation.PayrollCalcuationId }, createdPayrollCalculation);
//        }

//        [HttpPut("{id}")]
//        public async Task<ActionResult> UpdatePayrollCalculation(int id, PayrollCalculation payrollCalculation)
//        {
//            if (id != payrollCalculation.PayrollCalcuationId)
//            {
//                return BadRequest();
//            }

//            await _repository.UpdatePayrollCalculationAsync(payrollCalculation);
//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        public async Task<ActionResult> DeletePayrollCalculation(int id)
//        {
//            var result = await _repository.DeletePayrollCalculationAsync(id);
//            if (!result)
//            {
//                return NotFound();
//            }

//            return NoContent();
//        }


//        [HttpPost("{id}/payslip")]
//        public async Task<ActionResult<string>> GeneratePaySlip(int id, [FromBody] PaySlipRequestModel model)
//        {
//            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
//            if (payrollCalculation == null)
//            {
//                return NotFound();
//            }

//            // Assuming `model` contains the required data for overtime, absence report, leaves, and pay date
//            string paySlipDetails = payrollCalculation.GeneratePaySlip(model.Overtimes, model.AbsenceReport, model.Leaves, model.PayDate);
//            return Ok(paySlipDetails);
//        }
//    }
//    public class PaySlipRequestModel
//    {
//        public List<Overtime> Overtimes { get; set; }
//        public AbsenceReport AbsenceReport { get; set; }
//        public List<Leave> Leaves { get; set; }
//        public DateTime PayDate { get; set; }
//    }
//}
using Fanush.DAL.Interfaces.PayrollInterface;
using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.PayrollManagement;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fanush.Controllers.PayrollManagement
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    [AllowAnonymous]
    public class PayrollCalculationController : ControllerBase
    {
        private readonly IPayrollCalculationRepository _repository;
        private readonly IOvertimeRepository _overtimeRepository;
        private readonly IAbsenceReportRepository _absenceReportRepository;
        private readonly ILeaveRepository _leaveRepository;
        private readonly ILogger<PayrollCalculationController> _logger;

        public PayrollCalculationController(IPayrollCalculationRepository repository, IOvertimeRepository overtimeRepository,
    IAbsenceReportRepository absenceReportRepository,
    ILeaveRepository leaveRepository, ILogger<PayrollCalculationController> logger)
        {
            _repository = repository;
            _overtimeRepository = overtimeRepository;
            _absenceReportRepository = absenceReportRepository;
            _leaveRepository = leaveRepository;
            _logger = logger;
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

        // Calculate Overtime Endpoint
        [HttpPost("{id}/calculate-overtime")]
        public async Task<ActionResult<decimal>> CalculateOvertime(int id, [FromBody] Overtime overtime)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            decimal overtimeAmount = payrollCalculation.CalculateOvertimeAmount(overtime);
            return Ok(overtimeAmount);
        }

        // Calculate Absence Deduction Endpoint
        [HttpPost("{id}/calculate-absence-deduction")]
        public async Task<ActionResult<decimal>> CalculateAbsenceDeduction(int id, [FromBody] AbsenceReport absenceReport)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            decimal deductionAmount = payrollCalculation.CalculateAbsenceDeduction(absenceReport);
            return Ok(deductionAmount);
        }

        // Calculate Unpaid Leave Deduction Endpoint
        [HttpPost("{id}/calculate-unpaid-leave-deduction")]
        public async Task<ActionResult<decimal>> CalculateUnpaidLeaveDeduction(int id, [FromBody] List<Leave> leaves)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            decimal deductionAmount = payrollCalculation.CalculateUnpaidLeaveDeduction(leaves);
            return Ok(deductionAmount);
        }

        // Calculate Total Deduction Endpoint
        [HttpPost("{id}/calculate-total-deduction")]
        public async Task<ActionResult<decimal>> CalculateTotalDeduction(int id, [FromBody] TotalDeductionRequestModel model)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            decimal totalDeduction = payrollCalculation.CalculateTotalDeduction(model.AbsenceReport, model.Leaves);
            return Ok(totalDeduction);
        }

        // Calculate Gross Payable Amount Endpoint
        [HttpPost("{id}/calculate-gross-payable")]
        public async Task<ActionResult<decimal>> CalculateGrossPayable(int id, [FromBody] List<Overtime> overtimes)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            decimal grossPayableAmount = payrollCalculation.CalculateGrossPayableAmount(overtimes);
            return Ok(grossPayableAmount);
        }

        // Calculate Net Payable Amount Endpoint
        [HttpPost("{id}/calculate-net-payable")]
        public async Task<ActionResult<decimal>> CalculateNetPayable(int id, [FromBody] NetPayableRequestModel model)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            decimal netPayableAmount = payrollCalculation.CalculateNetPayableAmount(model.Overtimes, model.AbsenceReport, model.Leaves);
            return Ok(netPayableAmount);
        }

        // Generate PaySlip Endpoint
        [HttpPost("{id}/payslip")]
        public async Task<ActionResult<string>> GeneratePaySlip(int id, [FromBody] PaySlipRequestModel model)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                return NotFound();
            }

            string paySlipDetails = payrollCalculation.GeneratePaySlip(model.Overtimes, model.AbsenceReport, model.Leaves, model.PayDate);
            return Ok(paySlipDetails);
        }
        // Get Full Payment Slip for an Employee
        //[HttpGet("{id}/full-payment-slip")]
        //public async Task<ActionResult<string>> GetFullPaymentSlip(int id)
        //{
        //    // Retrieve the payroll calculation entry for the employee
        //    var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
        //    if (payrollCalculation == null)
        //    {
        //        return NotFound();
        //    }

        //    // Actual data retrieval logic
        //    var overtimes = await _overtimeRepository.GetOvertimeByEmployeeIdAsync(id);
        //    var absenceReport = await _absenceReportRepository.GetAbsenceReportByEmployeeIdAsync(id);
        //    var leaves = await _leaveRepository.GetLeavesByEmployeeIdAsync(id);

        //    DateTime payDate = DateTime.Now; // Set the pay date

        //    // Calculate the full payment slip details using the GeneratePaySlip method
        //    string fullPaymentSlip = payrollCalculation.GeneratePaySlip(overtimes, absenceReport, leaves, payDate);

        //    // Return the generated payment slip as the response
        //    return Ok(fullPaymentSlip);
        //}
        [HttpGet("{id}/full-payment-slip")]
        public async Task<ActionResult<string>> GetFullPaymentSlip(int id)
        {
            var payrollCalculation = await _repository.GetPayrollCalculationByIdAsync(id);
            if (payrollCalculation == null)
            {
                _logger.LogWarning("PayrollCalculation with ID {Id} not found.", id);
                return NotFound($"PayrollCalculation with ID {id} not found.");
            }

            var overtimes = await _overtimeRepository.GetOvertimeByEmployeeIdAsync(id) ?? new List<Overtime>();
            var absenceReport = await _absenceReportRepository.GetAbsenceReportByEmployeeIdAsync(id);
            var leaves = await _leaveRepository.GetLeavesByEmployeeIdAsync(id) ?? new List<Leave>();

            // Log the retrieved data
            _logger.LogInformation("PayrollCalculation: {PayrollCalculation}", payrollCalculation);
            _logger.LogInformation("Overtimes: {Overtimes}", overtimes);
            _logger.LogInformation("AbsenceReport: {AbsenceReport}", absenceReport);
            _logger.LogInformation("Leaves: {Leaves}", leaves);

            if (absenceReport == null)
            {
                _logger.LogWarning("AbsenceReport not found for Employee ID {Id}.", id);
                return NotFound("AbsenceReport not found.");
            }

            DateTime payDate = DateTime.Now; // Set the pay date

            try
            {
                string fullPaymentSlip = payrollCalculation.GeneratePaySlip(overtimes, absenceReport, leaves, payDate);
                return Ok(fullPaymentSlip);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating pay slip for Employee ID {Id}", id);
                return StatusCode(500, "Internal server error");
            }
        }


    }




    // Models for complex request bodies
    public class TotalDeductionRequestModel
    {
        public AbsenceReport AbsenceReport { get; set; }
        public List<Leave> Leaves { get; set; }
    }

    public class NetPayableRequestModel
    {
        public List<Overtime> Overtimes { get; set; }
        public AbsenceReport AbsenceReport { get; set; }
        public List<Leave> Leaves { get; set; }
    }

    public class PaySlipRequestModel
    {
        public List<Overtime> Overtimes { get; set; }
        public AbsenceReport AbsenceReport { get; set; }
        public List<Leave> Leaves { get; set; }
        public DateTime PayDate { get; set; }
    }
}
