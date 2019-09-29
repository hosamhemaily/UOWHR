using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HiringDocumentTransactionTbl
    {
        public long HiringDocumentTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? HiringDocumentId { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string HiringDocumentStatus { get; set; }
        public DateTime? HiringDocumentIssueDate { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual HiringDocumentTbl HiringDocument { get; set; }
    }
}
