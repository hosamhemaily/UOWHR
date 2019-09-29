using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ResidencyRenewalTransactionTbl
    {
        public long ResidencyRenewalTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? RenewalDate { get; set; }
        public long? OldResidencyTypeId { get; set; }
        public DateTime? OldResidencyDate { get; set; }
        public DateTime? OldResidencyExpireDate { get; set; }
        public long? NewResidencyTypeId { get; set; }
        public DateTime? NewResidencyDate { get; set; }
        public DateTime? NewResidencyExpireDate { get; set; }
        public int? ResidencyNumber { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual ResidencyTypeTbl NewResidencyType { get; set; }
    }
}
