using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ChangeOfStatusDetailsTbl
    {
        public ChangeOfStatusDetailsTbl()
        {
            ChangeOfCostCenterDetailsTbl = new HashSet<ChangeOfCostCenterDetailsTbl>();
        }

        public long ChangeOfStatusDetailsId { get; set; }
        public long ChangeOfStatusTransactionId { get; set; }
        public long? ChangeableFieldId { get; set; }
        public string OldValue { get; set; }
        public string OldValueEnName { get; set; }
        public string OldValueArName { get; set; }
        public string NewValue { get; set; }
        public string NewValueEnName { get; set; }
        public string NewValueArName { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public DateTime? InsuranceDate { get; set; }

        public virtual ChangeOfStatusTransactionTbl ChangeOfStatusTransaction { get; set; }
        public virtual ChangeableFieldTbl ChangeableField { get; set; }
        public virtual ICollection<ChangeOfCostCenterDetailsTbl> ChangeOfCostCenterDetailsTbl { get; set; }
    }
}
