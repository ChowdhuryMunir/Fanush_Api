using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.Entities.PerformenceManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.PerformenceManagementRepositories
{
    public class PerformanceReportRepository : IPerformanceReportRepository
    {
        private readonly FanushDbContext _context;

        public PerformanceReportRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PerformanceReport>> Get()
        {
            return await _context.PerformanceReports.ToListAsync(); 
  
        }

        public async Task<PerformanceReport> Get(int id)
        {
            return await _context.Set<PerformanceReport>().FindAsync(id);
        }

        public async Task<object> Post(PerformanceReport entity)
        {
            _context.PerformanceReports.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, PerformanceReport entity)
        {
            if (id != entity.PerformanceReportId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingReport = await _context.PerformanceReports.FindAsync(id);

            if (existingReport == null)
            {
                return NotFound("Nothing");
            }

            existingReport.EmployeeId = entity.EmployeeId;
            existingReport.EvaluatorId = entity.EvaluatorId;
            existingReport.EvaluationDate = entity.EvaluationDate;
            existingReport.PerformanceScore = entity.PerformanceScore;
            existingReport.GoalsMet = entity.GoalsMet;
            existingReport.Strengths = entity.Strengths;
            existingReport.AreasForImprovement = entity.AreasForImprovement;
            existingReport.Achievements = entity.Achievements;
            existingReport.DevelopmentPlan = entity.DevelopmentPlan;
            existingReport.Comments = entity.Comments;
            existingReport.OverallRating = entity.OverallRating;
            existingReport.ReviewPeriodStart = entity.ReviewPeriodStart;
            existingReport.ReviewPeriodEnd = entity.ReviewPeriodEnd;
            existingReport.Status = entity.Status;
            existingReport.ActionItems = entity.ActionItems;

            try
            {
                await _context.SaveChangesAsync();
                return existingReport;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update performance report. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update performance report: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var report = await _context.PerformanceReports.FindAsync(id);
            if (report != null)
            {
                _context.PerformanceReports.Remove(report);
                await _context.SaveChangesAsync();
                return report;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
