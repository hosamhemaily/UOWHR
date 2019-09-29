using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EosRuleTbl
    {
        public EosRuleTbl()
        {
            EosBenifitTransactionTbl = new HashSet<EosBenifitTransactionTbl>();
            EosRuleDetailsTbl = new HashSet<EosRuleDetailsTbl>();
        }

        public long EosRuleId { get; set; }
        public long? PropertyId { get; set; }
        public string EosRuleCode { get; set; }
        public string EosRuleEnName { get; set; }
        public string EosRuleArName { get; set; }
        public string EosRuleArNameShadow { get; set; }
        public string EffectedPayments { get; set; }
        public bool? ComputeNoneCompletedYearProportionallyYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EosBenifitTransactionTbl> EosBenifitTransactionTbl { get; set; }
        public virtual ICollection<EosRuleDetailsTbl> EosRuleDetailsTbl { get; set; }
    }
}
