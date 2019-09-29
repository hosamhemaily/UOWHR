using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PermissionTransactionTbl
    {
        public long PermissionTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? PermissionTypeId { get; set; }
        public DateTime? PermissionDate { get; set; }
        public int? PermissionHours { get; set; }
        public int? PermissionMinutes { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }
        public string CurrentBalance { get; set; }
        public string PendingBalance { get; set; }
        public string BalanceAfter { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual PermissionTypeTbl PermissionType { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
