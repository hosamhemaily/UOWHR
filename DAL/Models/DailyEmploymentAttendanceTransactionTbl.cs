using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DailyEmploymentAttendanceTransactionTbl
    {
        public long DailyEmploymentAttendanceTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? TheDate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
    }
}
