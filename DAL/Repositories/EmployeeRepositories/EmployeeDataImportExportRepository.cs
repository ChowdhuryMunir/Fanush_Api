using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeDataImportExportRepository : IEmployeeDataImportExportRepository
    {
        private readonly FanushDbContext _context;

        public EmployeeDataImportExportRepository(FanushDbContext context)
        {
            _context = context;
        }
        public async Task<object> Delete(int id)
        {
            var entity = await _context.EmployeeDataImportExports.FindAsync(id);
            if (entity == null)
            {
                return null; 
            }

            _context.EmployeeDataImportExports.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<EmployeeDataImportExport>> Get()
        {
            return await _context.EmployeeDataImportExports.ToListAsync();
        }

        public async Task<EmployeeDataImportExport> Get(int id)
        {
            return await _context.EmployeeDataImportExports.FindAsync(id);
        }

        public async Task<object> Post(EmployeeDataImportExport entity)
        {
            _context.EmployeeDataImportExports.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, EmployeeDataImportExport entity)
        {
            if (id != entity.ImportExportId)
            {
                return null; // or throw an exception if required
            }

            _context.Entry(entity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDataImportExportExists(id))
                {
                    return null; // or throw an exception if required
                }
                else
                {
                    throw;
                }
            }

            return entity;
        }
        private bool EmployeeDataImportExportExists(int id)
        {
            return _context.EmployeeDataImportExports.Any(e => e.ImportExportId == id);
        }
    }
}
