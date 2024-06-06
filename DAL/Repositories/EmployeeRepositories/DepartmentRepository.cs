using Fanush.DAL.Interfaces;
using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly FanushDbContext _context;

        public DepartmentRepository(FanushDbContext context)
        {
            _context = context;
        }
        public async Task<object> Delete(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
                return department;
            }
            return null;
        }

        //public async Task<IEnumerable<Department>> Get()
        //{
        //    return await _context.Set<Department>().ToListAsync();
        //}

        public async Task<IEnumerable<Department>> Get()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> Get(int id)
        {
            return await _context.Set<Department>().FindAsync(id);
        }

        public async Task<object> Post(Department entity)
        {
            _context.Departments.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Department entity)
        {
            var department = _context.Departments.Find(id);
            department.DepartmentName=entity.DepartmentName;
            department.IsActive=entity.IsActive;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
