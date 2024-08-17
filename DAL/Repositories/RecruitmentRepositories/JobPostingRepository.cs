using Fanush.DAL.Interfaces.RecruitmentInterface;
using Fanush.Entities.RecruitmentManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.RecruitmentRepositories
{
    public class JobPostingRepository : IJobPostingRepository
    {
        private readonly FanushDbContext _context;

        public JobPostingRepository(FanushDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobPosting>> Get()
        {
            return await _context.JobPostings.ToListAsync();
        }

        public async Task<JobPosting> Get(int id)
        {
            return await _context.JobPostings.FindAsync(id);
        }

        public async Task<object> Post(JobPosting entity)
        {
            _context.JobPostings.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, JobPosting entity)
        {
            if (id != entity.JobPostingId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingJobPosting = await _context.JobPostings.FindAsync(id);

            if (existingJobPosting == null)
            {
                return NotFound("Job posting not found.");
            }

            // Update properties of existingJobPosting with values from entity
            existingJobPosting.Title = entity.Title;
            existingJobPosting.Description = entity.Description;
            existingJobPosting.IsInternal = entity.IsInternal;
            existingJobPosting.IsActive = entity.IsActive;
            existingJobPosting.PostingDate = entity.PostingDate;
            existingJobPosting.ApplicationDeadline = entity.ApplicationDeadline;
            existingJobPosting.StartDate = entity.StartDate;
            existingJobPosting.City = entity.City;
            existingJobPosting.ContactEmail = entity.ContactEmail;
            existingJobPosting.ContactPhone = entity.ContactPhone;
            existingJobPosting.SalaryInformation = entity.SalaryInformation;
            existingJobPosting.Requirements = entity.Requirements;
            existingJobPosting.JobType = entity.JobType;
            existingJobPosting.ExperienceRequired = entity.ExperienceRequired;
            existingJobPosting.EducationRequired = entity.EducationRequired;
            existingJobPosting.SkillsRequired = entity.SkillsRequired;
            existingJobPosting.BenefitsOffered = entity.BenefitsOffered;
            existingJobPosting.WorkSchedule = entity.WorkSchedule;
            existingJobPosting.IsRemoteWork = entity.IsRemoteWork;

            try
            {
                await _context.SaveChangesAsync();
                return existingJobPosting;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update job posting. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update job posting: {ex.Message}");
            }
        }

        public async Task<object> Delete(int id)
        {
            var jobPosting = await _context.JobPostings.FindAsync(id);
            if (jobPosting != null)
            {
                _context.JobPostings.Remove(jobPosting);
                await _context.SaveChangesAsync();
                return jobPosting;
            }
            return null;
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
