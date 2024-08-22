using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly FanushDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public EmployeeRepository(FanushDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
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
            if (entity.ImageFile != null)
            {
                entity.ImagePath = await UploadImageAsync(entity.ImageFile);
            }
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
            if (entity.ImageFile != null)
            {
                existingEmployee.ImagePath = await UploadImageAsync(entity.ImageFile);
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


        public async Task<int> CountTotalEmployees()
        {
            return await _context.Employees.CountAsync();
        }

        public async Task<int> CountActiveEmployees()
        {
            return await _context.Employees.CountAsync(e => e.IsActive);
        }

        public async Task<int> CountInactiveEmployees()
        {
            return await _context.Employees.CountAsync(e => !e.IsActive);
        }

        public async Task<Dictionary<string, int>> CountEmployeesByDepartment()
        {
            return await _context.Employees
                .GroupBy(e => e.Department.DepartmentName)
                .Select(g => new { Department = g.Key, Count = g.Count() })
                .ToDictionaryAsync(g => g.Department, g => g.Count);
        }

        public async Task<int> CountAttendance(DateTime startDate, DateTime endDate)
        {
            return await _context.ClockInOuts
                .CountAsync(a => a.ClockInTime >= startDate && a.ClockInTime <= endDate);
        }

        public async Task<int> CountTodayAttendance()
        {
            var today = DateTime.Today;
            return await CountAttendance(today, today.AddDays(1).AddTicks(-1));
        }

        public async Task<int> CountTodayAbsentEmployees()
        {
            var today = DateTime.UtcNow.Date;

            // Get all employee IDs
            var allEmployeeIds = await _context.Employees.Select(e => e.EmployeeId).ToListAsync();

            // Get employee IDs who have clocked in today
            var clockedInEmployeeIds = await _context.ClockInOuts
                .Where(c => c.Timestamp.Date == today && c.Action.ToLower() == "clockin")
                .Select(c => c.EmployeeId)
                .Distinct()
                .ToListAsync();

            // Employees who are absent today
            var absentEmployeeIds = allEmployeeIds.Except(clockedInEmployeeIds).Count();

            return absentEmployeeIds;
        }

        public async Task<int> CountWeeklyAttendance()
        {
            var today = DateTime.Today;
            var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7).AddTicks(-1);
            return await CountAttendance(startOfWeek, endOfWeek);
        }

        public async Task<int> CountMonthlyAttendance()
        {
            var today = DateTime.Today;
            var startOfMonth = new DateTime(today.Year, today.Month, 1);
            var endOfMonth = startOfMonth.AddMonths(1).AddTicks(-1);
            return await CountAttendance(startOfMonth, endOfMonth);
        }

        public async Task<int> CountEmployeesOnLeave()
        {
            var today = DateTime.Today;
            return await _context.Leaves
                .CountAsync(l => l.StartDate <= today && l.EndDate >= today);
        }


        ///For Image

        private async Task<string> UploadImageAsync(IFormFile imageFile)
        {
            // Ensure wwwroot/Files folder exists
            string uploadsFolder = Path.Combine(_environment.WebRootPath, "Images");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            // Construct the URL for the uploaded file
            var imagePath = Path.Combine("/Images", uniqueFileName);

            return imagePath;
        }
    }
}


