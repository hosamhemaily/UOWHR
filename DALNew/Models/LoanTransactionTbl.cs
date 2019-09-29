using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class LoanTransactionTbl
    {
        public LoanTransactionTbl()
        {
            LoanTransactionDetailsTbl = new HashSet<LoanTransactionDetailsTbl>();
        }

        public long LoanTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? LoanId { get; set; }
        public DateTime? LoanDate { get; set; }
        public int? LoanStartingYear { get; set; }
        public int? LoanStartingMonth { get; set; }
        public double? LoanAmount { get; set; }
        public int? LoanPeriod { get; set; }
        public byte? LoanStatus { get; set; }
        public int? LoanEndYear { get; set; }
        public int? LoanEndMonth { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual LoanTbl Loan { get; set; }
        public virtual ICollection<LoanTransactionDetailsTbl> LoanTransactionDetailsTbl { get; set; }
    }
}
