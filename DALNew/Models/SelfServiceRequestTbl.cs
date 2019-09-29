using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SelfServiceRequestTbl
    {
        public SelfServiceRequestTbl()
        {
            SelfServiceApprovalTbl = new HashSet<SelfServiceApprovalTbl>();
        }

        public long SelfServiceRequestId { get; set; }
        public long? PropertyId { get; set; }
        public int? SysRequestTypeId { get; set; }
        public long? RequestMasterId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? RequestIssueDate { get; set; }
        public int? SysRequestStatusId { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public DateTime? RequestFromDate { get; set; }
        public DateTime? RequestToDate { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
        public virtual SysRequestTypeTbl SysRequestType { get; set; }
        public virtual ICollection<SelfServiceApprovalTbl> SelfServiceApprovalTbl { get; set; }
    }
}
