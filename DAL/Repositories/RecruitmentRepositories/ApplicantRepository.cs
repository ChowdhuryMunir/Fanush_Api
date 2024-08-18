using Fanush.DAL.Interfaces.RecruitmentInterface;
using Fanush.Entities.RecruitmentManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.RecruitmentRepositories
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly FanushDbContext _context;

        public ApplicantRepository(FanushDbContext context)
        {
            _context = context;
        }


        public async Task<object> Delete(int id)
        {
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant != null)
            {
                _context.Applicants.Remove(applicant);
                await _context.SaveChangesAsync();
                return applicant;
            }
            return null;
        }

        public async Task<IEnumerable<Applicant>> Get()
        {
            return await _context.Applicants.ToListAsync();
        }

        public async Task<Applicant> Get(int id)
        {
            return await _context.Set<Applicant>().FindAsync(id);
        }

        public async Task<object> Post(Applicant entity)
        {
            _context.Applicants.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Applicant entity)
        {
            if (id != entity.ApplicantId)
            {
                throw new ArgumentException("Mismatched id in route parameter and entity body.");
            }

            var existingApplicant = await _context.Applicants.FindAsync(id);

            if (existingApplicant == null)
            {
                return NotFound("Applicant not found.");
            }

            // Update properties of existingApplicant with values from entity
            existingApplicant.ApplicantName = entity.ApplicantName;
            existingApplicant.Email = entity.Email;
            existingApplicant.ResumeUrl = entity.ResumeUrl;
            // Note: ResumeFile is not stored in the database and hence should not be updated.
            existingApplicant.Status = entity.Status;
            existingApplicant.AppliedDate = entity.AppliedDate;
            existingApplicant.PhoneNumber = entity.PhoneNumber;
            existingApplicant.LinkedinProfileUrl = entity.LinkedinProfileUrl;
            existingApplicant.Address = entity.Address;
            existingApplicant.City = entity.City;
            existingApplicant.ZipCode = entity.ZipCode;
            existingApplicant.Country = entity.Country;
            existingApplicant.ExpectedSalary = entity.ExpectedSalary;
            existingApplicant.Languages = entity.Languages;
            existingApplicant.Skills = entity.Skills;
            existingApplicant.References = entity.References;

            try
            {
                await _context.SaveChangesAsync();
                return existingApplicant;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new Exception("Failed to update applicant. Concurrency issue occurred.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update applicant: {ex.Message}");
            }
        }

        private object NotFound(string message)
        {
            return message;
        }
    }
}
