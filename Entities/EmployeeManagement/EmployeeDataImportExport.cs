using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fanush.Models.EmployeeManagement
{
    public class EmployeeDataImportExport
    {
        [Key]
        public int ImportExportId { get; set; }

        public string? Type { get; set; } // Example: Import, Export

        public string? DataPath { get; set; }

        [NotMapped]
        public IFormFile? DataFile { get; set; }
        public DateTime ImportExportDate { get; set; }
        public bool IsActive { get; set; }
    }
}
