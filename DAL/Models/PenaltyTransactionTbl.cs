using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PenaltyTransactionTbl
    {
        public long PenaltyTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? PenaltyDate { get; set; }
        public byte? PenaltyTypeId { get; set; }
        public long? PenaltyId { get; set; }
        public long? PenaltyRepeatId { get; set; }
        public double? PenaltyDays { get; set; }
        public string PenaltyDescription { get; set; }
        public string Notes { get; set; }
        public bool? ThroughMachineYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual PenaltyTbl Penalty { get; set; }
        public virtual PenaltyRepeatTbl PenaltyRepeat { get; set; }
        public virtual PenaltyTypeTbl PenaltyType { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
