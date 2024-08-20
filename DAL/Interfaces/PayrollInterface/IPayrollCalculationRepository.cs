using Fanush.Entities.PayrollManagement;

namespace Fanush.DAL.Interfaces.PayrollInterface
{
    public interface IPayrollCalculationRepository
    {
        Task<IEnumerable<PayrollCalculation>> GetAllPayrollCalculationsAsync();
        Task<PayrollCalculation> GetPayrollCalculationByIdAsync(int id);
        Task<PayrollCalculation> AddPayrollCalculationAsync(PayrollCalculation payrollCalculation);
        Task<PayrollCalculation> UpdatePayrollCalculationAsync(PayrollCalculation payrollCalculation);
        Task<bool> DeletePayrollCalculationAsync(int id);
    }
}
