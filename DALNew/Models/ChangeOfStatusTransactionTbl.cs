using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ChangeOfStatusTransactionTbl
    {
        public ChangeOfStatusTransactionTbl()
        {
            ChangeOfSalaryDetailsTbl = new HashSet<ChangeOfSalaryDetailsTbl>();
            ChangeOfStatusDetailsTbl = new HashSet<ChangeOfStatusDetailsTbl>();
        }

        public long ChangeOfStatusTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public long? ChangeOfStatusReasonId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool? PersentageYn { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? ApprovedYn { get; set; }
        public int? SysRequestStatusId { get; set; }
        public bool? PayrollTransactionYn { get; set; }

        public virtual ChangeOfStatusReasonTbl ChangeOfStatusReason { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual ICollection<ChangeOfSalaryDetailsTbl> ChangeOfSalaryDetailsTbl { get; set; }
        public virtual ICollection<ChangeOfStatusDetailsTbl> ChangeOfStatusDetailsTbl { get; set; }
    }
}
