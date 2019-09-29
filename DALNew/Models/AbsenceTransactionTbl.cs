using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AbsenceTransactionTbl
    {
        public long AbsenceTransactionId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? DaysNumber { get; set; }
        public bool? WithoutPermissionYn { get; set; }
        public bool? PenaltyYn { get; set; }
        public long? PenaltyTransactionId { get; set; }
        public bool? ThrowMachineYn { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
