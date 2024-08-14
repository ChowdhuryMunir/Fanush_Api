using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FanushDbContext _context;

        public EmployeeRepository(FanushDbContext context)
        {
            _context = context;
        }
        public async Task<object> Delete(int id)
        {
            var empployee = await _context.Employees.FindAsync(id);
            if (empployee != null)
            {
                _context.Employees.Remove(empployee);
                await _context.SaveChangesAsync();
                return empployee;
            }
            return null;
        }

        public async Task<IEnumerable<Employee>> Get()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> Get(int id)
        {
            return await _context.Set<Employee>().FindAsync(id);
        }

        public async Task<object> Post(Employee entity)
        {
            _context.Employees.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Employee entity)
        {
            if (id != entity.EmployeeId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingEmployee = await _context.Employees.FindAsync(id);

            if (existingEmployee == null)
            {
                return NotFound("Nothing");
            }

            // Update properties of existingEmployee with values from entity
            existingEmployee.FirstName = entity.FirstName;
            existingEmployee.LastName = entity.LastName;
            existingEmployee.Email = entity.Email;
            existingEmployee.DateOfBirth = entity.DateOfBirth;
            existingEmployee.EmergencyContactNumber = entity.EmergencyContactNumber;
            existingEmployee.Gender = entity.Gender;
            existingEmployee.DateOfJoining = entity.DateOfJoining;
            existingEmployee.DepartmentId = entity.DepartmentId;
            existingEmployee.JobTitle = entity.JobTitle;
            existingEmployee.IsActive = entity.IsActive;
            existingEmployee.PresentAddress = entity.PresentAddress;
            existingEmployee.PermanentAddress = entity.PermanentAddress;
            existingEmployee.PhoneNumber = entity.PhoneNumber;
            existingEmployee.NationalId = entity.NationalId;
            existingEmployee.Nationality = entity.Nationality;
            existingEmployee.PassportNumber = entity.PassportNumber;
            existingEmployee.FathersName = entity.FathersName;
            existingEmployee.MothersName = entity.MothersName;
            existingEmployee.MaritalStatus = entity.MaritalStatus;
            existingEmployee.Religion = entity.Religion;
            existingEmployee.ProfileImagePath = entity.ProfileImagePath;
            existingEmployee.CreatedBy = entity.CreatedBy;
            existingEmployee.CreatedOn = entity.CreatedOn;
            existingEmployee.UpdatedBy = entity.UpdatedBy;
            existingEmployee.UpdatedOn = entity.UpdatedOn;
            



            try
            {
                await _context.SaveChangesAsync();
                return existingEmployee; 
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update employee. Concurrency issue occurred.");
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update employee: {ex.Message}");
                
            }
        }

        private object NotFound(string a)
        {
            return a = "Nothing";
        }
    }
}
