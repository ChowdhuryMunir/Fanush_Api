using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class JobTitle
    {
        [Key]
        public int JobTitleId { get; set; }
        public string? JobTitleName { get; set; }

        public bool IsActive { get; set; }

        public virtual List<Employee>?  Employee { get; set;}
    }
}
