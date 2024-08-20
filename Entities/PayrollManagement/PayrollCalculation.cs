using Fanush.Models.EmployeeManagement;
using Fanush.Entities.TimeAndAttendence;

namespace Fanush.Entities.PayrollManagement
{
    public class PayrollCalculation
    {
        public int PayrollCalcuationId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public decimal BasicSalary { get; set; }

        public decimal HouseRent { get; set; }

        public decimal MedicalAllowence { get; set; }

        public decimal ConveyanceAllowence { get; set; }

        public decimal OtherAllowence { get; set; }

        // Deduction Portion

        public decimal DeductedAmount { get; set; }

        // Overtime calculation
        public decimal CalculateOvertimeAmount(Overtime overtime)
        {
            // Assuming overtime rate is 1.5 times the regular hourly rate
            decimal overtimeRate = 1.5m;
            decimal hourlyRate = BasicSalary / 208; // Assuming 208 working hours in a month
            decimal overtimeAmount = overtime.Hours * overtimeRate * hourlyRate;
            return overtimeAmount;
        }

        // Deduction calculation for absence
        public decimal CalculateAbsenceDeduction(AbsenceReport absenceReport)
        {
            // Assuming deduction rate is the employee's daily rate
            decimal dailyRate = BasicSalary / 30; // Assuming 30 working days in a month
            decimal deductionAmount = dailyRate * absenceReport.DaysAbsent;
            return deductionAmount;
        }

        // Deduction calculation for unpaid leave
        public decimal CalculateUnpaidLeaveDeduction(List<Leave> leaves)
        {
            decimal totalDeduction = 0;

            foreach (var leave in leaves)
            {
                if (!leave.IsPaidLeave)
                {
                    // Assuming deduction rate is the employee's daily rate
                    decimal dailyRate = BasicSalary / 30; // Assuming 30 working days in a month
                    decimal deductionAmount = dailyRate * leave.NumberOfDays;
                    totalDeduction += deductionAmount;
                }
            }

            return totalDeduction;
        }

        // Total deduction calculation
        public decimal CalculateTotalDeduction(AbsenceReport absenceReport, List<Leave> leaves)
        {
            decimal totalDeduction = CalculateAbsenceDeduction(absenceReport);
            totalDeduction += CalculateUnpaidLeaveDeduction(leaves);
            return totalDeduction;
        }

        // Gross payable amount calculation
        public decimal CalculateGrossPayableAmount(List<Overtime> overtimes)
        {
            decimal grossPayableAmount = BasicSalary + HouseRent + MedicalAllowence + ConveyanceAllowence + OtherAllowence;

            // Add overtime amounts
            foreach (var overtime in overtimes)
            {
                grossPayableAmount += CalculateOvertimeAmount(overtime);
            }

            return grossPayableAmount;
        }

        // Net payable amount calculation
        public decimal CalculateNetPayableAmount(List<Overtime> overtimes, AbsenceReport absenceReport, List<Leave> leaves)
        {
            decimal grossPayableAmount = CalculateGrossPayableAmount(overtimes);
            decimal totalDeduction = CalculateTotalDeduction(absenceReport, leaves);
            decimal netPayableAmount = grossPayableAmount - totalDeduction;
            return netPayableAmount;
        }
    }
}