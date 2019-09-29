using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TaxBalanceTransactionTbl
    {
        public TaxBalanceTransactionTbl()
        {
            TaxBalanceTransactionDetailsTbl = new HashSet<TaxBalanceTransactionDetailsTbl>();
        }

        public long TaxBalanceTransactionId { get; set; }
        public long PropertyId { get; set; }
        public int? TheYear { get; set; }
        public long? TaxRuleId { get; set; }
        public int? FromMonth { get; set; }
        public int? ToMonth { get; set; }
        public DateTime? TaxBalanceDate { get; set; }
        public bool? CalculatedYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? PayDifferenceSalaryYn { get; set; }

        public virtual PropertyTbl Property { get; set; }
        public virtual ICollection<TaxBalanceTransactionDetailsTbl> TaxBalanceTransactionDetailsTbl { get; set; }
    }
}
