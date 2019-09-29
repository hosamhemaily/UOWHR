using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AdditionalPaymentTransactionTbl
    {
        public AdditionalPaymentTransactionTbl()
        {
            AdditionalPaymentTransactionDetailsTbl = new HashSet<AdditionalPaymentTransactionDetailsTbl>();
        }

        public long AdditionalPaymentTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public DateTime? AdditionalPaymentDate { get; set; }
        public long? PaymentId { get; set; }
        public int? PayWay { get; set; }
        public bool? TaxableYn { get; set; }
        public bool? PaidYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }

        public virtual PaymentTbl Payment { get; set; }
        public virtual ICollection<AdditionalPaymentTransactionDetailsTbl> AdditionalPaymentTransactionDetailsTbl { get; set; }
    }
}
