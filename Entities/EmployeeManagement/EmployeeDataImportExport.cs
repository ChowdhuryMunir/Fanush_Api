using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class EmployeeDataImportExport
    {
        [Key]
        public int ImportExportId { get; set; }

        //[Required(ErrorMessage = "Import or export type is required.")]
        public string Type { get; set; } // Example: Import, Export

        //[Required(ErrorMessage = "File name is required.")]
        public string FileName { get; set; }

        //[Required(ErrorMessage = "File path is required.")]
        public string FilePath { get; set; }

        //[Required(ErrorMessage = "Import or export date is required.")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Import/Export Date")]
        public DateTime ImportExportDate { get; set; }
        public bool IsActive { get; set; }
    }
}
