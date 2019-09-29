using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AttendanceMachineLogTbl
    {
        public long AttendanceMachineLogId { get; set; }
        public string EmployeeClockNumber { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public TimeSpan? TransactionTime { get; set; }
        public int? TransactionHour { get; set; }
        public int? TransactionMinute { get; set; }
        public string TransactionFlag { get; set; }
        public byte? AttendanceTransactionFlagId { get; set; }
        public string SourceType { get; set; }
        public long? AttendanceMachineId { get; set; }

        public virtual AttendanceTransactionFlagTbl AttendanceTransactionFlag { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
