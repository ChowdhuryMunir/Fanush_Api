using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
