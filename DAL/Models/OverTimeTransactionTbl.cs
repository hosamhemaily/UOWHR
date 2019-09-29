using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class OverTimeTransactionTbl
    {
        public long OverTimeTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? OverTimeTypeId { get; set; }
        public DateTime? OverTimeDate { get; set; }
        public int? OverTimeHours { get; set; }
        public int? OverTimeMinutes { get; set; }
        public int? OverTimeTotalHours { get; set; }
        public int? OverTimeTotalMinutes { get; set; }
        public bool? ThroughMachineYn { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? GmApprovedYn { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual OverTimeTypeTbl OverTimeType { get; set; }
    }
}
