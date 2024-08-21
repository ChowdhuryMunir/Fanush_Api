using Fanush.Entities.TimeAndAttendence;

namespace Fanush.DAL.Interfaces.TimeAndAttendeceInterface
{
    public interface IAbsenceReportRepository : IGenericRepository<AbsenceReport>
    {
        Task<AbsenceReport> GetAbsenceReportByEmployeeIdAsync(int employeeId);
    }
}
