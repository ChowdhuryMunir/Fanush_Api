using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeLifecycleRepository : IEmployeeLifecycleRepository
    {
        private readonly FanushDbContext _context;

        public EmployeeLifecycleRepository(FanushDbContext context)
        {
            _context = context;
        }
        public async Task<object> Delete(int id)
        {
            var employeeLifeCycle = await _context.EmployeeLifecycles.FindAsync(id);
            if (employeeLifeCycle != null)
            {
                _context.EmployeeLifecycles.Remove(employeeLifeCycle);
                await _context.SaveChangesAsync();
                return employeeLifeCycle;
            }
            return null;
        }

        public async Task<IEnumerable<EmployeeLifecycle>> Get()
        {
            return await _context.EmployeeLifecycles.ToListAsync();
        }

        public async Task<EmployeeLifecycle> Get(int id)
        {
            return await _context.Set<EmployeeLifecycle>().FindAsync(id);
        }

        public async Task<object> Post(EmployeeLifecycle entity)
        {
            _context.EmployeeLifecycles.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public  async Task<object> Put(int id, EmployeeLifecycle entity)
        {
            if (id != entity.LifecycleId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingEmployeeCycle = await _context.EmployeeLifecycles.FindAsync(id);

            if (existingEmployeeCycle == null)
            {
                return NotFound("Nothing");
            }

            // Update properties of existingEmployee with values from entity
            existingEmployeeCycle.IsActive = entity.IsActive;
            existingEmployeeCycle.ActionType = entity.ActionType;
            existingEmployeeCycle.ActionDate = entity.ActionDate;
           


            try
            {
                await _context.SaveChangesAsync();
                return existingEmployeeCycle;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update employee Life Cycle. Concurrency issue occurred.");

            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update employee Life Cycle: {ex.Message}");

            }

        }


        private object NotFound(string a)
        {
            return a = "Nothing";
        }
    }
}
