using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.BenefitsAdministration
{
    public class AccountManagement
    {
        [Required(ErrorMessage = "EmployeeId is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "FSAId is required.")]
        public int FSAId { get; set; }

        [Required(ErrorMessage = "DCAPId is required.")]
        public int DCAPId { get; set; }

        [Required(ErrorMessage = "IsActive is required.")]
        public bool IsActive { get; set; }

        [Display(Name = "Account Type")]
        public string AccountType { get; set; }

        [Display(Name = "Account Status")]
        public string AccountStatus { get; set; }

        [Display(Name = "Account Holder")]
        public string AccountHolder { get; set; }

        [Display(Name = "Employer Contribution")]
        [DataType(DataType.Currency)]
        public decimal EmployerContribution { get; set; }

        [Display(Name = "Termination Date")]
        [DataType(DataType.Date)]
        public DateTime TerminationDate { get; set; }
    }
}
