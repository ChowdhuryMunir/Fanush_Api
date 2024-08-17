using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.TimeAndAttendence;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.TimeAndAttendanceRepositories
{
    public class ClockInOutRepository : IClockInOutRepository
    {
        private readonly FanushDbContext _context;

        public ClockInOutRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClockInOut>> Get()
        {
            return await _context.ClockInOuts.ToListAsync();
        }

        public async Task<ClockInOut> Get(int id)
        {
            return await _context.Set<ClockInOut>().FindAsync(id);
        }

        public async Task<object> Post(ClockInOut entity)
        {
            _context.ClockInOuts.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, ClockInOut entity)
        {
            if (id != entity.ClockInOutId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingClockInOut = await _context.ClockInOuts.FindAsync(id);

            if (existingClockInOut == null)
            {
                return NotFound("ClockInOut record not found.");
            }

            // Update properties of existingClockInOut with values from entity
            existingClockInOut.EmployeeId = entity.EmployeeId;
            existingClockInOut.Timestamp = entity.Timestamp;
            existingClockInOut.Action = entity.Action;
            existingClockInOut.Location = entity.Location;
            existingClockInOut.Notes = entity.Notes;
            existingClockInOut.ClockInTime = entity.ClockInTime;
            existingClockInOut.ClockOutTime = entity.ClockOutTime;
            existingClockInOut.IsLateArrival = entity.IsLateArrival;
            existingClockInOut.IsEarlyDeparture = entity.IsEarlyDeparture;
            existingClockInOut.IsWorkday = entity.IsWorkday;
            existingClockInOut.OvertimeHours = entity.OvertimeHours;
            existingClockInOut.IsOvertime = entity.IsOvertime;
            existingClockInOut.ApprovedBy = entity.ApprovedBy;
            existingClockInOut.IsActive = entity.IsActive;
            existingClockInOut.LateArrivalReason = entity.LateArrivalReason;
            existingClockInOut.EarlyDepartureReason = entity.EarlyDepartureReason;

            try
            {
                await _context.SaveChangesAsync();
                return existingClockInOut;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update ClockInOut record. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update ClockInOut record: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var clockInOut = await _context.ClockInOuts.FindAsync(id);
            if (clockInOut != null)
            {
                _context.ClockInOuts.Remove(clockInOut);
                await _context.SaveChangesAsync();
                return clockInOut;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
