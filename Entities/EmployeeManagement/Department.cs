using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string? DepartmentName { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }
}
