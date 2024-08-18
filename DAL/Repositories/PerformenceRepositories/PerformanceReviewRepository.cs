using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.Entities.PerformenceManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.PerformenceManagementRepositories
{
    public class PerformanceReviewRepository : IPerformanceReviewRepository
    {
        private readonly FanushDbContext _context;

        public PerformanceReviewRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PerformanceReview>> Get()
        {
            return await _context.PerformanceReviews.ToListAsync();
        }

        public async Task<PerformanceReview> Get(int id)
        {
            return await _context.Set<PerformanceReview>().FindAsync(id);
        }

        public async Task<object> Post(PerformanceReview entity)
        {
            _context.PerformanceReviews.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, PerformanceReview entity)
        {
            if (id != entity.PerformanceReviewId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingReview = await _context.PerformanceReviews.FindAsync(id);

            if (existingReview == null)
            {
                return NotFound("Nothing");
            }

            existingReview.EmployeeId = entity.EmployeeId;
            existingReview.ReviewerId = entity.ReviewerId;
            existingReview.Feedback = entity.Feedback;
            existingReview.PerformanceRating = entity.PerformanceRating;
            existingReview.Comments = entity.Comments;
            existingReview.ReviewDate = entity.ReviewDate;
            existingReview.ReviewType = entity.ReviewType;

            try
            {
                await _context.SaveChangesAsync();
                return existingReview;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update performance review. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update performance review: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var review = await _context.PerformanceReviews.FindAsync(id);
            if (review != null)
            {
                _context.PerformanceReviews.Remove(review);
                await _context.SaveChangesAsync();
                return review;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
