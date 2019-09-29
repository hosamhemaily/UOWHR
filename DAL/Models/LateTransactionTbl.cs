using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LateTransactionTbl
    {
        public long LateTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? LateTypeId { get; set; }
        public DateTime? LateDate { get; set; }
        public int? LateHours { get; set; }
        public int? LateMinutes { get; set; }
        public int? LateTotalHours { get; set; }
        public int? LateTotalMinutes { get; set; }
        public bool? PenaltyYn { get; set; }
        public long? PenaltyTransactionId { get; set; }
        public bool? ThroughMachineYn { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual LateTypeTbl LateType { get; set; }
    }
}
