using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class EmployeeDataImportExport
    {
        [Key]
        public int ImportExportId { get; set; }

        public string? Type { get; set; } // Example: Import, Export

        public string? FileName { get; set; }

        public string? FilePath { get; set; }
        public DateTime ImportExportDate { get; set; }
        public bool IsActive { get; set; }
    }
}
