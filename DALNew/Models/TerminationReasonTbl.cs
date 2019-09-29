using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TerminationReasonTbl
    {
        public TerminationReasonTbl()
        {
            TerminationTransactionTbl = new HashSet<TerminationTransactionTbl>();
        }

        public long TerminationReasonId { get; set; }
        public long? PropertyId { get; set; }
        public string TerminationReasonCode { get; set; }
        public string TerminationReasonEnName { get; set; }
        public string TerminationReasonArName { get; set; }
        public string TerminationReasonArNameShadow { get; set; }
        public bool? BlackListYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<TerminationTransactionTbl> TerminationTransactionTbl { get; set; }
    }
}
