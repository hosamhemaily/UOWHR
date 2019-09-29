using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class WorkInGovernmentTypeTbl
    {
        public WorkInGovernmentTypeTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte WorkInGovernmentTypeId { get; set; }
        public string WorkInGovernmentTypeEnName { get; set; }
        public string WorkInGovernmentTypeArName { get; set; }

        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
