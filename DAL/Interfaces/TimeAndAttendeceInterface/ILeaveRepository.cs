using Fanush.Entities.TimeAndAttendence;

namespace Fanush.DAL.Interfaces.TimeAndAttendeceInterface
{
    public interface ILeaveRepository : IGenericRepository<Leave>
    {
        Task<List<Leave>> GetLeavesByEmployeeIdAsync(int employeeId);
    }
}
