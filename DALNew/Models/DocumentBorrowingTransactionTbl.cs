using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DocumentBorrowingTransactionTbl
    {
        public long DocumentBorrowingTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public bool? SameEmployeeYn { get; set; }
        public long? EmployeeId { get; set; }
        public long? BorrowingEmployeeId { get; set; }
        public long? HiringDocumentId { get; set; }
        public DateTime? BorrowingDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string BorrowingReason { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? ReturnYn { get; set; }
        public DateTime? ReturnInDate { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual HiringDocumentTbl HiringDocument { get; set; }
    }
}
