using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CustodyTransactionTbl
    {
        public long CustodyTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? CustodyId { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string CustodyNumber { get; set; }
        public bool? ReturnedYn { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }

        public virtual CustodyTbl Custody { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
