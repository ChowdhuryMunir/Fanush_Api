using Fanush.Models.EmployeeManagement;

namespace Fanush.DAL.Interfaces.EmployeeInterface
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {

        Task<int> CountTotalEmployees();
        Task<int> CountActiveEmployees();
        Task<int> CountInactiveEmployees();
        Task<Dictionary<string, int>> CountEmployeesByDepartment();
        Task<int> CountTodayAttendance();
        Task<int> CountWeeklyAttendance();
        Task<int> CountMonthlyAttendance();
        Task<int> CountEmployeesOnLeave();
        Task<int> CountTodayAbsentEmployees();
    }
}
