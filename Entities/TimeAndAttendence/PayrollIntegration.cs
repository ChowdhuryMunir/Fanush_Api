using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.TimeAndAttendence
{
    public class PayrollIntegration
    {
        [Key]
        public int PayrollIntegrationId { get; set; }

        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Payroll System ID is required.")]
        [Display(Name = "Payroll System ID")]
        public int PayrollSystemId { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be a non-negative number.")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Display(Name = "Integration Date")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Integration date is required.")]
        public DateTime IntegrationDate { get; set; }

        [Display(Name = "Integration Type")]
        public string IntegrationType { get; set; }

        [Display(Name = "Transaction ID")]
        public string TransactionId { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        // Additional properties
        [Display(Name = "Pay Period Start Date")]
        [DataType(DataType.Date)]
        public DateTime PayPeriodStartDate { get; set; } // Start date of the pay period

        [Display(Name = "Pay Period End Date")]
        [DataType(DataType.Date)]
        public DateTime PayPeriodEndDate { get; set; } // End date of the pay period

        [Display(Name = "Pay Frequency")]
        public string PayFrequency { get; set; } // Frequency of pay (e.g., weekly, bi-weekly, monthly)

        [Display(Name = "Deductions")]
        public decimal Deductions { get; set; } // Total deductions from the paycheck

        [Display(Name = "Net Pay")]
        public decimal NetPay { get; set; } // Net pay after deductions

        [Display(Name = "Tax Amount")]
        public decimal TaxAmount { get; set; } // Total tax amount deducted from the paycheck

        [Display(Name = "Gross Pay")]
        public decimal GrossPay { get; set; } // Gross pay before deductions
    }
}
