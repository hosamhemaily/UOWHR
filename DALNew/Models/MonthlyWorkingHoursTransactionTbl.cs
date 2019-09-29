using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class MonthlyWorkingHoursTransactionTbl
    {
        public long MonthlyWorkingHoursTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public double? HoursNumber { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
    }
}
