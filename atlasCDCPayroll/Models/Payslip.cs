using System;
using System.ComponentModel.DataAnnotations;

namespace atlasCDCPayroll.Models
{
    public class Payslip
    {
        [Key]
        public int PayslipId { get; set; }
        public int EmployeeId { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public int Year { get; set; }
        public DateTime GeneratedOn { get; set; }
        public decimal BasicSalary { get; set; }
        public int NoOfLeaves { get; set; }
        public decimal SalaryPerDay { get; set; }
        public decimal DeductionForLeaves { get; set; }
        public decimal NetSalary { get; set; }

        public Employee Employee { get; set; }
    }
}