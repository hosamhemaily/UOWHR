using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeFeesTbl
    {
        public long EmployeeFeesId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public double? SchoolFees { get; set; }
        public double? HealthInsurance { get; set; }
        public double? LifeInsurance { get; set; }
        public double? BaladyaCard { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public double? Bonus { get; set; }
        public double? Loyalty { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
    }
}
