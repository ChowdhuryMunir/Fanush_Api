using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.TimeAndAttendanceRepositories
{
    public class OvertimeRepository : IOvertimeRepository
    {
        private readonly FanushDbContext _context;

        public OvertimeRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Overtime>> Get()
        {
            return await _context.Overtimes.ToListAsync();
        }

        public async Task<Overtime> Get(int id)
        {
            return await _context.Set<Overtime>().FindAsync(id);
        }

        public async Task<List<Overtime>> GetOvertimeByEmployeeIdAsync(int employeeId)
        {
            return await _context.Overtimes.Where(o => o.EmployeeId == employeeId).ToListAsync();
        }

        public async Task<object> Post(Overtime entity)
        {
            _context.Overtimes.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Overtime entity)
        {
            if (id != entity.OvertimeId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingOvertime = await _context.Overtimes.FindAsync(id);

            if (existingOvertime == null)
            {
                return NotFound("Overtime record not found.");
            }

            // Update properties of existingOvertime with values from entity
            existingOvertime.EmployeeId = entity.EmployeeId;
            existingOvertime.Date = entity.Date;
            existingOvertime.Hours = entity.Hours;
            existingOvertime.IsActive = entity.IsActive;
            existingOvertime.OvertimeType = entity.OvertimeType;
            existingOvertime.ApprovalStatus = entity.ApprovalStatus;
            existingOvertime.ApprovedBy = entity.ApprovedBy;
            existingOvertime.ApprovalDate = entity.ApprovalDate;
            existingOvertime.Reason = entity.Reason;
            existingOvertime.AttachmentUrl = entity.AttachmentUrl;
            existingOvertime.CreatedDate = entity.CreatedDate;
            existingOvertime.LastModifiedDate = entity.LastModifiedDate;
            existingOvertime.CreatedBy = entity.CreatedBy;
            existingOvertime.LastModifiedBy = entity.LastModifiedBy;
            existingOvertime.Department = entity.Department;
            existingOvertime.Project = entity.Project;

            try
            {
                await _context.SaveChangesAsync();
                return existingOvertime;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update Overtime record. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update Overtime record: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var overtime = await _context.Overtimes.FindAsync(id);
            if (overtime != null)
            {
                _context.Overtimes.Remove(overtime);
                await _context.SaveChangesAsync();
                return overtime;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
