using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SelfServiceEffectsApprovalTbl
    {
        public long SelfServiceEffectsApprovalId { get; set; }
        public long? PropertyId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public long? SupervisorEmployeeId { get; set; }
        public bool? ApprovedYn { get; set; }
        public bool? HrApprovedYn { get; set; }
    }
}
