using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.Entities.PerformenceManagement;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.PerformenceManagementRepositories
{
    public class GoalRepository : IGoalRepository
    {
        private readonly FanushDbContext _context;

        public GoalRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Goal>> Get()
        {
            return await _context.Goals.ToListAsync();
        }

        public async Task<Goal> Get(int id)
        {
            return await _context.Set<Goal>().FindAsync(id);
        }

        public async Task<object> Post(Goal entity)
        {
            _context.Goals.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Goal entity)
        {
            if (id != entity.GoalId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingGoal = await _context.Goals.FindAsync(id);

            if (existingGoal == null)
            {
                return NotFound("Nothing");
            }

            existingGoal.Title = entity.Title;
            existingGoal.Description = entity.Description;
            existingGoal.StartDate = entity.StartDate;
            existingGoal.EndDate = entity.EndDate;
            existingGoal.EmployeeId = entity.EmployeeId;
            existingGoal.GoalStatus = entity.GoalStatus;
            existingGoal.Progress = entity.Progress;
            existingGoal.IsActive = entity.IsActive;
            existingGoal.LastUpdatedDate = entity.LastUpdatedDate;
            existingGoal.UpdatedBy = entity.UpdatedBy;
            existingGoal.CompletionDate = entity.CompletionDate;
            existingGoal.AssignedByUserId = entity.AssignedByUserId;
            existingGoal.Comments = entity.Comments;

            try
            {
                await _context.SaveChangesAsync();
                return existingGoal;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update goal. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update goal: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var goal = await _context.Goals.FindAsync(id);
            if (goal != null)
            {
                _context.Goals.Remove(goal);
                await _context.SaveChangesAsync();
                return goal;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
