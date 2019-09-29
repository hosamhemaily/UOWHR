using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentGroupTbl
    {
        public PaymentGroupTbl()
        {
            BonusTransactionTbl = new HashSet<BonusTransactionTbl>();
            DeductionTbl = new HashSet<DeductionTbl>();
            PaymentGroupDetailsTbl = new HashSet<PaymentGroupDetailsTbl>();
            PaymentTbl = new HashSet<PaymentTbl>();
        }

        public long PaymentGroupId { get; set; }
        public long? PropertyId { get; set; }
        public string PaymentGroupCode { get; set; }
        public string PaymentGroupEnName { get; set; }
        public string PaymentGroupArName { get; set; }
        public string PaymentGroupArNameShadow { get; set; }
        public bool? ShowInPayslipYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<BonusTransactionTbl> BonusTransactionTbl { get; set; }
        public virtual ICollection<DeductionTbl> DeductionTbl { get; set; }
        public virtual ICollection<PaymentGroupDetailsTbl> PaymentGroupDetailsTbl { get; set; }
        public virtual ICollection<PaymentTbl> PaymentTbl { get; set; }
    }
}
