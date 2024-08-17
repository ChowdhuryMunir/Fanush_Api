

using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class EmployeeLifecycle
    {
        [Key]
        public int LifecycleId { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        //[Required(ErrorMessage = "Action type is required.")]
        public string? ActionType { get; set; } // Example: Onboarding, Transfer, Promotion, Termination

        public DateTime ActionDate { get; set; }

        public bool IsActive { get; set; }
    }
}
