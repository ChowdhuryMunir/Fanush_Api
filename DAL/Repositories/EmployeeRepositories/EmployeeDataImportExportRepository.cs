using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeDataImportExportRepository : IEmployeeDataImportExportRepository
    {
        public Task<object> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmployeeDataImportExport>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<EmployeeDataImportExport> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<object> Post(EmployeeDataImportExport entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> Put(int id, EmployeeDataImportExport entity)
        {
            throw new NotImplementedException();
        }
    }
}
