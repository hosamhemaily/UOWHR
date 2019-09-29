using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SalaryCalculationWayTbl
    {
        public SalaryCalculationWayTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte SalaryCalculationWayId { get; set; }
        public string SalaryCalculationWayEnName { get; set; }
        public string SalaryCalculationWayArName { get; set; }

        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
