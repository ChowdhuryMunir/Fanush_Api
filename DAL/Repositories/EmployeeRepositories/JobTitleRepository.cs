using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class JobTitleRepository : IJobTitleRepository
    {
        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JobTitle>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<JobTitle> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(JobTitle entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, JobTitle entity)
        {
            throw new NotImplementedException();
        }
    }
}
