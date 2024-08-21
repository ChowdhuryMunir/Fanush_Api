using System;
using System.Collections.Generic;
using Fanush.Models.EmployeeManagement;
using Fanush.Entities.TimeAndAttendence;
using System.ComponentModel.DataAnnotations;

namespace Fanush.Entities.PayrollManagement
{
    public class PayrollCalculation
    {
        [Key]
        public int PayrollCalcuationId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public decimal BasicSalary { get; set; }
        public decimal HouseRent { get; set; }
        public decimal MedicalAllowence { get; set; }
        public decimal ConveyanceAllowence { get; set; }
        public decimal OtherAllowence { get; set; }


        // Overtime calculation
        public decimal CalculateOvertimeAmount(Overtime overtime)
        {
            decimal overtimeRate = 1.5m;
            decimal hourlyRate = BasicSalary / 208;
            decimal overtimeAmount = overtime.Hours * overtimeRate * hourlyRate;
            return overtimeAmount;
        }

        // Deduction calculation for absence
        public decimal CalculateAbsenceDeduction(AbsenceReport absenceReport)
        {
            decimal dailyRate = BasicSalary / 30;
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
                    decimal dailyRate = BasicSalary / 30;
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

        // Generate a detailed PaySlip for the month
        //    public string GeneratePaySlip(List<Overtime> overtimes, AbsenceReport absenceReport, List<Leave> leaves, DateTime payDate)
        //    {
        //        decimal grossPayableAmount = BasicSalary + HouseRent + MedicalAllowence + ConveyanceAllowence + OtherAllowence;

        //        // Check if overtime records exist
        //        if (overtimes != null)
        //        {
        //            foreach (var overtime in overtimes)
        //            {
        //                grossPayableAmount += CalculateOvertimeAmount(overtime);
        //            }
        //        }

        //        decimal totalDeduction = 0;

        //        // Check if absence report exists
        //        if (absenceReport != null)
        //        {
        //            totalDeduction += CalculateAbsenceDeduction(absenceReport);
        //        }

        //        // Check if leave records exist
        //        if (leaves != null)
        //        {
        //            totalDeduction += CalculateUnpaidLeaveDeduction(leaves);
        //        }

        //        decimal netPayableAmount = grossPayableAmount - totalDeduction;

        //        // Generate PaySlip
        //        return $@"
        //    PaySlip for {Employee.FirstName} {Employee.LastName} ({payDate.ToString("MMMM yyyy")})
        //    -------------------------------------------------
        //    Gross Salary: {grossPayableAmount:C}
        //    Total Deductions: -{totalDeduction:C}
        //    -------------------------------------------------
        //    Net Salary: {netPayableAmount:C}
        //    -------------------------------------------------
        //    Paid on: {payDate.ToShortDateString()}
        //";
        //    }

        public string GeneratePaySlip(List<Overtime> overtimes, AbsenceReport absenceReport, List<Leave> leaves, DateTime payDate)
        {
            decimal grossPayableAmount = BasicSalary + HouseRent + MedicalAllowence + ConveyanceAllowence + OtherAllowence;

            if (overtimes != null && overtimes.Any())
            {
                foreach (var overtime in overtimes)
                {
                    grossPayableAmount += CalculateOvertimeAmount(overtime);
                }
            }

            decimal totalDeduction = 0;

            if (absenceReport != null)
            {
                totalDeduction += CalculateAbsenceDeduction(absenceReport);
            }

            if (leaves != null && leaves.Any())
            {
                totalDeduction += CalculateUnpaidLeaveDeduction(leaves);
            }

            decimal netPayableAmount = grossPayableAmount - totalDeduction;

            return $@"
PaySlip for {Employee?.FirstName ?? "Unknown"} {Employee?.LastName ?? "Unknown"} ({payDate.ToString("MMMM yyyy")})
-------------------------------------------------
Gross Salary: {grossPayableAmount:C}
Total Deductions: -{totalDeduction:C}
-------------------------------------------------
Net Salary: {netPayableAmount:C}
-------------------------------------------------
Paid on: {payDate.ToShortDateString()}
";
        }



    }
}
