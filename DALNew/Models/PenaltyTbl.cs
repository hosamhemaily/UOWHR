using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PenaltyTbl
    {
        public PenaltyTbl()
        {
            PenaltyRepeatTbl = new HashSet<PenaltyRepeatTbl>();
            PenaltyTransactionTbl = new HashSet<PenaltyTransactionTbl>();
        }

        public long PenaltyId { get; set; }
        public long? PropertyId { get; set; }
        public string PenaltyCode { get; set; }
        public string PenaltyEnName { get; set; }
        public string PenaltyArName { get; set; }
        public string PenaltyArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<PenaltyRepeatTbl> PenaltyRepeatTbl { get; set; }
        public virtual ICollection<PenaltyTransactionTbl> PenaltyTransactionTbl { get; set; }
    }
}
