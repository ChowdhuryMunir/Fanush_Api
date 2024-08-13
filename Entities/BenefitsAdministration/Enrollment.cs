using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.BenefitsAdministration
{
    public class Enrollment
    {
        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "HealthInsuranceId is required.")]
        public int HealthInsuranceId { get; set; }

        [Required(ErrorMessage = "RetirementPlanId is required.")]
        public int RetirementPlanId { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        // Additional properties for real-time HR management
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; } // Date of enrollment

        [Display(Name = "Enrollment Status")]
        public string EnrollmentStatus { get; set; } // Status of enrollment (e.g., pending, active, inactive)

        [Display(Name = "Enrollment Comments")]
        public string EnrollmentComments { get; set; } // Comments or notes related to the enrollment

        [Display(Name = "Enrollment Type")]
        public string EnrollmentType { get; set; }

        [Display(Name = "Enrollment Method")]
        public string EnrollmentMethod { get; set; }

        [Display(Name = "Confirmation Number")]
        public string ConfirmationNumber { get; set; }

        [Display(Name = "Approval Status")]
        public string ApprovalStatus { get; set; }
    }
}
