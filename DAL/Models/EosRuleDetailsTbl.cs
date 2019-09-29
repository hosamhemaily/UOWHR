using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EosRuleDetailsTbl
    {
        public long EosRuleDetailsId { get; set; }
        public long? EosRuleId { get; set; }
        public int? ServiceYearsUpTo { get; set; }
        public string SliceFormula { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EosRuleTbl EosRule { get; set; }
    }
}
