using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.TimeAndAttendanceRepositories
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly FanushDbContext _context;

        public LeaveRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Leave>> Get()
        {
            return await _context.Leaves.ToListAsync();
        }

        public async Task<Leave> Get(int id)
        {
            return await _context.Set<Leave>().FindAsync(id);
        }

        public async Task<List<Leave>> GetLeavesByEmployeeIdAsync(int employeeId)
        {
            return await _context.Leaves.Where(l => l.EmployeeId == employeeId).ToListAsync();
        }

        public async Task<object> Post(Leave entity)
        {
            _context.Leaves.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Leave entity)
        {
            if (id != entity.LeaveId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingLeave = await _context.Leaves.FindAsync(id);

            if (existingLeave == null)
            {
                return NotFound("Leave record not found.");
            }

            // Update properties of existingLeave with values from entity
            existingLeave.EmployeeId = entity.EmployeeId;
            existingLeave.LeaveType = entity.LeaveType;
            existingLeave.StartDate = entity.StartDate;
            existingLeave.EndDate = entity.EndDate;
            existingLeave.Status = entity.Status;
            existingLeave.Reason = entity.Reason;
            existingLeave.RequestedBy = entity.RequestedBy;
            existingLeave.ApprovalDate = entity.ApprovalDate;
            existingLeave.Approver = entity.Approver;
            existingLeave.ApprovalComments = entity.ApprovalComments;
            existingLeave.IsActive = entity.IsActive;
            existingLeave.IsPaidLeave = entity.IsPaidLeave;
            existingLeave.LeaveCategory = entity.LeaveCategory;

            try
            {
                await _context.SaveChangesAsync();
                return existingLeave;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update Leave record. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update Leave record: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var leave = await _context.Leaves.FindAsync(id);
            if (leave != null)
            {
                _context.Leaves.Remove(leave);
                await _context.SaveChangesAsync();
                return leave;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
