using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PenaltyRepeatTbl
    {
        public PenaltyRepeatTbl()
        {
            PenaltyTransactionTbl = new HashSet<PenaltyTransactionTbl>();
        }

        public long PenaltyRepeatId { get; set; }
        public long? PenaltyId { get; set; }
        public string PenaltyRepeatCode { get; set; }
        public string PenaltyRepeatEnName { get; set; }
        public string PenaltyRepeatArName { get; set; }
        public string PenaltyRepeatArNameShadow { get; set; }
        public double? PenaltyDays { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual PenaltyTbl Penalty { get; set; }
        public virtual ICollection<PenaltyTransactionTbl> PenaltyTransactionTbl { get; set; }
    }
}
