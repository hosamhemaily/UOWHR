using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class LoanTbl
    {
        public LoanTbl()
        {
            LoanTransactionTbl = new HashSet<LoanTransactionTbl>();
        }

        public long LoanId { get; set; }
        public long? PropertyId { get; set; }
        public string LoanCode { get; set; }
        public string LoanEnName { get; set; }
        public string LoanEnShortName { get; set; }
        public string LoanArName { get; set; }
        public string LoanArNameShadow { get; set; }
        public string LoanArShortName { get; set; }
        public long? AccountNumberId { get; set; }
        public double? MaxAmount { get; set; }
        public int? MaxNumber { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual AccountNumberTbl AccountNumber { get; set; }
        public virtual ICollection<LoanTransactionTbl> LoanTransactionTbl { get; set; }
    }
}
