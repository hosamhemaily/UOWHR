using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ChangeOfCostCenterDetailsTbl
    {
        public long ChangeOfCostCenterDetailsId { get; set; }
        public long? ChangeOfStatusDetailsId { get; set; }
        public byte? RecordTypeOldNew { get; set; }
        public long? PropertyId { get; set; }
        public long? BranchId { get; set; }
        public long? DivisionId { get; set; }
        public long? DepartmentId { get; set; }
        public long? UnitId { get; set; }
        public long? SectionId { get; set; }
        public double? PaymentsRate { get; set; }
        public double? DeductionsRate { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ChangeOfStatusDetailsTbl ChangeOfStatusDetails { get; set; }
    }
}
