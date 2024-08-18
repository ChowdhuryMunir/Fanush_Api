using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.Entities.PerformenceManagement;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.PerformenceManagementRepositories
{
    public class DevelopmentPlanRepository : IDevelopmentPlanRepository
    {
        private readonly FanushDbContext _context;

        public DevelopmentPlanRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DevelopmentPlan>> Get()
        {
            return await _context.DevelopmentPlans.ToListAsync();
        }

        public async Task<DevelopmentPlan> Get(int id)
        {
            return await _context.Set<DevelopmentPlan>().FindAsync(id);
        }

        public async Task<object> Post(DevelopmentPlan entity)
        {
            _context.DevelopmentPlans.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, DevelopmentPlan entity)
        {
            if (id != entity.DevelopmentPlanId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingPlan = await _context.DevelopmentPlans.FindAsync(id);

            if (existingPlan == null)
            {
                return NotFound("Nothing");
            }

            // Update properties of existingPlan with values from entity
            existingPlan.EmployeeId = entity.EmployeeId;
            existingPlan.Description = entity.Description;
            existingPlan.TargetCompletionDate = entity.TargetCompletionDate;
            existingPlan.DevelopmentPlanStatus = entity.DevelopmentPlanStatus;
            existingPlan.Progress = entity.Progress;
            existingPlan.IsActive = entity.IsActive;
            existingPlan.Feedback = entity.Feedback;
            existingPlan.Resources = entity.Resources;
            existingPlan.CompletionDate = entity.CompletionDate;

            try
            {
                await _context.SaveChangesAsync();
                return existingPlan;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update development plan. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update development plan: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var plan = await _context.DevelopmentPlans.FindAsync(id);
            if (plan != null)
            {
                _context.DevelopmentPlans.Remove(plan);
                await _context.SaveChangesAsync();
                return plan;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
