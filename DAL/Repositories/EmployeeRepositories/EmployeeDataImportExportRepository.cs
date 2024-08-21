using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.Models.EmployeeManagement;
using Microsoft.EntityFrameworkCore;

namespace Fanush.DAL.Repositories.EmployeeRepositories
{
    public class EmployeeDataImportExportRepository : IEmployeeDataImportExportRepository
    {
        private readonly FanushDbContext _context;
        private readonly IWebHostEnvironment _environment;


        public EmployeeDataImportExportRepository(FanushDbContext context)
        {
            _context = context;
        }
        public async Task<object> Delete(int id)
        {
            var entity = await _context.EmployeeDataImportExports.FindAsync(id);
            if (entity == null)
            {
                return null; 
            }

            _context.EmployeeDataImportExports.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<EmployeeDataImportExport>> Get()
        {
            return await _context.EmployeeDataImportExports.ToListAsync();
        }

        public async Task<EmployeeDataImportExport> Get(int id)
        {
            return await _context.EmployeeDataImportExports.FindAsync(id);
        }

        public async Task<object> Post(EmployeeDataImportExport entity)
        {
            if (entity.DataFile != null)
            {
                entity.DataPath = await UploadFileAsync(entity.DataFile);
            }
            _context.EmployeeDataImportExports.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, EmployeeDataImportExport entity)
        {
            if (id != entity.ImportExportId)
            {
                return null; // or throw an exception if required
            }

            _context.Entry(entity).State = EntityState.Modified;

            try
            {
                if (entity.DataFile != null)
                {
                    entity.DataPath = await UploadFileAsync(entity.DataFile);
                }
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeDataImportExportExists(id))
                {
                    return null; // or throw an exception if required
                }
                else
                {
                    throw;
                }
            }

            return entity;
        }
        private bool EmployeeDataImportExportExists(int id)
        {
            return _context.EmployeeDataImportExports.Any(e => e.ImportExportId == id);
        }

        private async Task<string> UploadFileAsync(IFormFile dataFile)
        {
            string uploadsFolder = Path.Combine(_environment.WebRootPath, "Files");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + dataFile.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await dataFile.CopyToAsync(fileStream);
            }
            var rsmUrl = "http://localhost:5041/" + "Files/" + uniqueFileName;

            return rsmUrl;
        }
    }
}
