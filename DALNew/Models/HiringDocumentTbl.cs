using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HiringDocumentTbl
    {
        public HiringDocumentTbl()
        {
            DocumentBorrowingTransactionTbl = new HashSet<DocumentBorrowingTransactionTbl>();
            HiringDocumentTransactionTbl = new HashSet<HiringDocumentTransactionTbl>();
        }

        public long HiringDocumentId { get; set; }
        public long? PropertyId { get; set; }
        public string HiringDocumentCode { get; set; }
        public string HiringDocumentEnName { get; set; }
        public string HiringDocumentArName { get; set; }
        public string HiringDocumentArNameShadow { get; set; }
        public bool? RequiredYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? ForGenderYn { get; set; }
        public int? GenderId { get; set; }
        public bool? ForPositionYn { get; set; }
        public string PositionIds { get; set; }

        public virtual ICollection<DocumentBorrowingTransactionTbl> DocumentBorrowingTransactionTbl { get; set; }
        public virtual ICollection<HiringDocumentTransactionTbl> HiringDocumentTransactionTbl { get; set; }
    }
}
