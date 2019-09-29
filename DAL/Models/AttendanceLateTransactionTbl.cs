using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AttendanceLateTransactionTbl
    {
        public long AttendanceLateTransactionId { get; set; }
        public long? AttendanceRuleId { get; set; }
        public double? FromMinute { get; set; }
        public double? ToMinute { get; set; }
        public long? LateTypeId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual AttendanceRuleTbl AttendanceRule { get; set; }
        public virtual LateTypeTbl LateType { get; set; }
    }
}
