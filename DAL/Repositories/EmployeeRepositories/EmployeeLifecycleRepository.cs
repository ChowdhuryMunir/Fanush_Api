using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeLifecycleRepository : IEmployeeLifecycleRepository
    {
        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeLifecycle>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeLifecycle> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(EmployeeLifecycle entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, EmployeeLifecycle entity)
        {
            throw new NotImplementedException();
        }
    }
}
