using Fanush.Entities.TimeAndAttendence;

namespace Fanush.DAL.Interfaces.TimeAndAttendeceInterface
{
    public interface IOvertimeRepository : IGenericRepository<Overtime>
    {
        Task<List<Overtime>> GetOvertimeByEmployeeIdAsync(int employeeId);
    }
}
