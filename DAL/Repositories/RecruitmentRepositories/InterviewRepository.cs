using Fanush.DAL.Interfaces.RecruitmentInterface;
using Fanush.Entities.RecruitmentManagement;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.RecruitmentRepositories
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly FanushDbContext _context;

        public InterviewRepository(FanushDbContext context)
        {
            _context = context;
        }


        public async Task<object> Delete(int id)
        {
            var interview = await _context.Interviews.FindAsync(id);
            if (interview != null)
            {
                _context.Interviews.Remove(interview);
                await _context.SaveChangesAsync();
                return interview;
            }
            return null;
        }

        public async Task<IEnumerable<Interview>> Get()
        {
            return await _context.Interviews.ToListAsync();
        }

        public async Task<Interview> Get(int id)
        {
            return await _context.Set<Interview>().FindAsync(id);
        }

        public async Task<object> Post(Interview entity)
        {
            _context.Interviews.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Interview entity)
        {
            if (id != entity.InterviewId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingInterviews = await _context.Interviews.FindAsync(id);

            if (existingInterviews == null)
            {
                return NotFound("Nothing");
            }

            // Update properties of existingEmployee with values from entity
            existingInterviews.Interviewer = entity.Interviewer;
            existingInterviews.Location = entity.Location;
            existingInterviews.Notes = entity.Notes;
            existingInterviews.IsActive = entity.IsActive;
            existingInterviews.DateTime = entity.DateTime;
            existingInterviews.ApplicantId = entity.ApplicantId;
            existingInterviews.InterviewType = entity.InterviewType;
            existingInterviews.DurationMinutes = entity.DurationMinutes;
            existingInterviews.Feedback = entity.Feedback;
            existingInterviews.Outcome = entity.Outcome;
            existingInterviews.FollowUp = entity.FollowUp;
            
        




            try
            {
                await _context.SaveChangesAsync();
                return existingInterviews;
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
