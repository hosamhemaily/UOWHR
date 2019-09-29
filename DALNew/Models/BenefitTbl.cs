using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BenefitTbl
    {
        public BenefitTbl()
        {
            BenefitTransactionTbl = new HashSet<BenefitTransactionTbl>();
        }

        public long BenefitId { get; set; }
        public long? PropertyId { get; set; }
        public string BenefitCode { get; set; }
        public string BenefitEnName { get; set; }
        public string BenefitArName { get; set; }
        public string BenefitArNameShadow { get; set; }
        public bool? RepeatableYn { get; set; }
        public int? RepeatEveryMonths { get; set; }
        public bool? HasValueYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<BenefitTransactionTbl> BenefitTransactionTbl { get; set; }
    }
}
