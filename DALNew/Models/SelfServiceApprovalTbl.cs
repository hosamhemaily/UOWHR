using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SelfServiceApprovalTbl
    {
        public long SelfServiceApprovalId { get; set; }
        public long? PropertyId { get; set; }
        public long? SelfServiceRequestId { get; set; }
        public long? SupervisorEmployeeId { get; set; }
        public int? SysRequestStatusId { get; set; }
        public int? ReportToTypeId { get; set; }
        public int? ReportToLevelId { get; set; }
        public bool? CanApproveYn { get; set; }
        public DateTime? ActionDate { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public long? DelegatedToEmployeeId { get; set; }
        public DateTime? RequestForApprovalDate { get; set; }

        public virtual SelfServiceRequestTbl SelfServiceRequest { get; set; }
        public virtual EmployeeTbl SupervisorEmployee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
