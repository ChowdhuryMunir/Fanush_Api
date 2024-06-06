using System.ComponentModel.DataAnnotations;

namespace Fanush.Models.EmployeeManagement
{
    public class EmployeeLifecycle
    {
        [Key]
        public int LifecycleId { get; set; }

        //[Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //[Required(ErrorMessage = "Action type is required.")]
        public string ActionType { get; set; } // Example: Onboarding, Transfer, Promotion, Termination

        //[Required(ErrorMessage = "Action date is required.")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Action Date")]
        public DateTime ActionDate { get; set; }

        public bool IsActive { get; set; }
    }
}
