using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class JobTitleRepository : IJobTitleRepository
    {
        private readonly FanushDbContext _context;

        public JobTitleRepository(FanushDbContext context)
        {
            _context = context;
        }
        public async Task<object> Delete(int id)
        {
            var jobTitle = await _context.JobTitles.FindAsync(id);
            if (jobTitle != null)
            {
                _context.JobTitles.Remove(jobTitle);
                await _context.SaveChangesAsync();
                return jobTitle;
            }
            return null;
        }

        public async Task<IEnumerable<JobTitle>> Get()
        {
            return await _context.JobTitles.ToListAsync();
        }

        public async Task<JobTitle> Get(int id)
        {
            return await _context.Set<JobTitle>().FindAsync(id);
        }

        public async Task<object> Post(JobTitle entity)
        {
            _context.JobTitles.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, JobTitle entity)
        {
            var jobTitles = _context.JobTitles.Find(id);
            jobTitles.JobTitleName = entity.JobTitleName;
            jobTitles.IsActive = entity.IsActive;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
