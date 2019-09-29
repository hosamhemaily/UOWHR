using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SelfServicesAttendanceApprovalTbl
    {
        public long SelfServicesAttendanceApprovalId { get; set; }
        public long? PropertyId { get; set; }
        public long? SupervisorEmployeeId { get; set; }
        public int? TheMonth { get; set; }
        public int? TheYear { get; set; }
        public bool? HrApprovedYn { get; set; }
    }
}
