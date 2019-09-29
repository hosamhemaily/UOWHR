using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ServiceChargeStatusTbl
    {
        public ServiceChargeStatusTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
        }

        public byte ServiceChargeStatusId { get; set; }
        public string ServiceChargeStatusEnName { get; set; }
        public string ServiceChargeStatusArName { get; set; }

        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
    }
}
