using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BonusDeductionsTbl
    {
        public long BonusDeductionsId { get; set; }
        public long? BonusTransactionId { get; set; }
        public long? DeductionId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual BonusTransactionTbl BonusTransaction { get; set; }
        public virtual DeductionTbl Deduction { get; set; }
    }
}
