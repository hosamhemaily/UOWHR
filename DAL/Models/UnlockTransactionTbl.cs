using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UnlockTransactionTbl
    {
        public long UnlockTransactionId { get; set; }
        public int? UnlockType { get; set; }
        public int? TransactionTypeId { get; set; }
        public long? TransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public long? PropertyId { get; set; }
    }
}
