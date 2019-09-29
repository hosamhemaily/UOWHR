using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BenefitTransactionTbl
    {
        public long BenefitTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? BenefitId { get; set; }
        public DateTime? BenefitDate { get; set; }
        public DateTime? RepeateDate { get; set; }
        public double? BenefitValue { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }

        public virtual BenefitTbl Benefit { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
