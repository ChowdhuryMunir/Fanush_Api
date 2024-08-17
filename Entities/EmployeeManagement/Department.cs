using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string? DepartmentName { get; set; }
        public bool IsActive { get; set; }

        public virtual List<Employee>? Employees { get; set; }
    }
}
