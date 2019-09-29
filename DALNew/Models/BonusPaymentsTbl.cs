using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BonusPaymentsTbl
    {
        public long BonusPaymentsId { get; set; }
        public long? BonusTransactionId { get; set; }
        public long? PaymentId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual BonusTransactionTbl BonusTransaction { get; set; }
        public virtual PaymentTbl Payment { get; set; }
    }
}
