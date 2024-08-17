using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.TimeAndAttendanceRepositories
{
    public class PayrollIntegrationRepository : IPayrollIntegrationRepository
    {
        private readonly FanushDbContext _context;

        public PayrollIntegrationRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PayrollIntegration>> Get()
        {
            return await _context.PayrollIntegrations.ToListAsync();
        }

        public async Task<PayrollIntegration> Get(int id)
        {
            return await _context.Set<PayrollIntegration>().FindAsync(id);
        }

        public async Task<object> Post(PayrollIntegration entity)
        {
            _context.PayrollIntegrations.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, PayrollIntegration entity)
        {
            if (id != entity.PayrollIntegrationId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingPayrollIntegration = await _context.PayrollIntegrations.FindAsync(id);

            if (existingPayrollIntegration == null)
            {
                return NotFound("Payroll integration record not found.");
            }

            // Update properties of existingPayrollIntegration with values from entity
            existingPayrollIntegration.EmployeeId = entity.EmployeeId;
            existingPayrollIntegration.PayrollSystemId = entity.PayrollSystemId;
            existingPayrollIntegration.Amount = entity.Amount;
            existingPayrollIntegration.IntegrationDate = entity.IntegrationDate;
            existingPayrollIntegration.IntegrationType = entity.IntegrationType;
            existingPayrollIntegration.TransactionId = entity.TransactionId;
            existingPayrollIntegration.IsActive = entity.IsActive;
            existingPayrollIntegration.PayPeriodStartDate = entity.PayPeriodStartDate;
            existingPayrollIntegration.PayPeriodEndDate = entity.PayPeriodEndDate;
            existingPayrollIntegration.PayFrequency = entity.PayFrequency;
            existingPayrollIntegration.Deductions = entity.Deductions;
            existingPayrollIntegration.NetPay = entity.NetPay;
            existingPayrollIntegration.TaxAmount = entity.TaxAmount;
            existingPayrollIntegration.GrossPay = entity.GrossPay;

            try
            {
                await _context.SaveChangesAsync();
                return existingPayrollIntegration;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update Payroll integration record. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update Payroll integration record: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var payrollIntegration = await _context.PayrollIntegrations.FindAsync(id);
            if (payrollIntegration != null)
            {
                _context.PayrollIntegrations.Remove(payrollIntegration);
                await _context.SaveChangesAsync();
                return payrollIntegration;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
