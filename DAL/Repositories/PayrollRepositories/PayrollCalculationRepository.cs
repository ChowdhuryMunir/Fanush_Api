using Fanush.DAL;
using Fanush.DAL.Interfaces.PayrollInterface;
using Fanush.Entities.PayrollManagement;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fanush.Repositories.PayrollManagement
{
    public class PayrollCalculationRepository : IPayrollCalculationRepository
    {
        private readonly FanushDbContext _context;

        public PayrollCalculationRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PayrollCalculation>> GetAllPayrollCalculationsAsync()
        {
            return await _context.PayrollCalculations.ToListAsync();
        }

        public async Task<PayrollCalculation> GetPayrollCalculationByIdAsync(int id)
        {
            return await _context.Set<PayrollCalculation>().FindAsync(id);
        }

        public async Task<PayrollCalculation> AddPayrollCalculationAsync(PayrollCalculation payrollCalculation)
        {
            _context.PayrollCalculations.Add(payrollCalculation);
            await _context.SaveChangesAsync();
            return payrollCalculation;
        }

        public async Task<PayrollCalculation> UpdatePayrollCalculationAsync(PayrollCalculation payrollCalculation)
        {
            _context.PayrollCalculations.Update(payrollCalculation);
            await _context.SaveChangesAsync();
            return payrollCalculation;
        }

        public async Task<bool> DeletePayrollCalculationAsync(int id)
        {
            var payrollCalculation = await _context.PayrollCalculations.FindAsync(id);
            if (payrollCalculation == null)
            {
                return false;
            }

            _context.PayrollCalculations.Remove(payrollCalculation);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
