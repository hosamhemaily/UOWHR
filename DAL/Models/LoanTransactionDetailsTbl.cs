using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LoanTransactionDetailsTbl
    {
        public long LoanTransactionDetailsId { get; set; }
        public long? LoanTransactionId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public double? LoanValue { get; set; }
        public byte? LoanStatus { get; set; }
        public bool? PaidYn { get; set; }

        public virtual LoanTransactionTbl LoanTransaction { get; set; }
    }
}
