using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BonusRangesTbl
    {
        public long BonusRangesId { get; set; }
        public long? BonusTransactionId { get; set; }
        public double? FromValue { get; set; }
        public double? ToValue { get; set; }
        public double? BonusValue { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual BonusTransactionTbl BonusTransaction { get; set; }
    }
}
