using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.Entities.TimeAndAttendence;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.TimeAndAttendanceRepositories
{
    public class AbsenceReportRepository : IAbsenceReportRepository
    {
        private readonly FanushDbContext _context;

        public AbsenceReportRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AbsenceReport>> Get()
        {
            return await _context.AbsenceReports.ToListAsync();
        }

        public async Task<AbsenceReport> Get(int id)
        {
            return await _context.Set<AbsenceReport>().FindAsync(id);
        }

        public async Task<AbsenceReport> GetAbsenceReportByEmployeeIdAsync(int employeeId)
        {
            return await _context.AbsenceReports.FirstOrDefaultAsync(ar => ar.EmployeeId == employeeId);
        }

        public async Task<object> Post(AbsenceReport entity)
        {
            _context.AbsenceReports.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, AbsenceReport entity)
        {
            if (id != entity.AbsenceReportId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingAbsenceReport = await _context.AbsenceReports.FindAsync(id);

            if (existingAbsenceReport == null)
            {
                return NotFound("Absence report not found.");
            }

            // Update properties of existingAbsenceReport with values from entity
            existingAbsenceReport.EmployeeId = entity.EmployeeId;
            existingAbsenceReport.StartDate = entity.StartDate;
            existingAbsenceReport.EndDate = entity.EndDate;
            existingAbsenceReport.Reason = entity.Reason;
            existingAbsenceReport.Approver = entity.Approver;
            existingAbsenceReport.Status = entity.Status;
            existingAbsenceReport.IsPaid = entity.IsPaid;
            existingAbsenceReport.ApprovedDate = entity.ApprovedDate;
            existingAbsenceReport.IsHalfDay = entity.IsHalfDay;
            existingAbsenceReport.HalfDayType = entity.HalfDayType;

            try
            {
                await _context.SaveChangesAsync();
                return existingAbsenceReport;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update Absence report. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update Absence report: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var absenceReport = await _context.AbsenceReports.FindAsync(id);
            if (absenceReport != null)
            {
                _context.AbsenceReports.Remove(absenceReport);
                await _context.SaveChangesAsync();
                return absenceReport;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
