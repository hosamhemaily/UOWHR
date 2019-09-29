using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BonusTransactionTbl
    {
        public BonusTransactionTbl()
        {
            BonusDeductionsTbl = new HashSet<BonusDeductionsTbl>();
            BonusPaymentsTbl = new HashSet<BonusPaymentsTbl>();
            BonusRangesTbl = new HashSet<BonusRangesTbl>();
            BonusTransactionDetailsTbl = new HashSet<BonusTransactionDetailsTbl>();
        }

        public long BonusTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public DateTime? BonusDate { get; set; }
        public byte? BonusTypeId { get; set; }
        public byte? BonusWayId { get; set; }
        public byte? PaymentDeductionNet { get; set; }
        public double? MinimumAmount { get; set; }
        public double? MaximumAmount { get; set; }
        public double? RateRatio { get; set; }
        public string RateFormula { get; set; }
        public byte? GroupPaymentNet { get; set; }
        public long? PaymentGroupId { get; set; }
        public long? PaymentId { get; set; }
        public int? RangeForMonth { get; set; }
        public int? RangeForYear { get; set; }
        public byte? BonusRatio { get; set; }
        public double? Value { get; set; }
        public bool? TaxableYn { get; set; }
        public bool? EvaluationYn { get; set; }
        public bool? PaidYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? PayWay { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionAr { get; set; }
        public int? BonusEvaluationType { get; set; }

        public virtual PaymentTbl Payment { get; set; }
        public virtual PaymentGroupTbl PaymentGroup { get; set; }
        public virtual ICollection<BonusDeductionsTbl> BonusDeductionsTbl { get; set; }
        public virtual ICollection<BonusPaymentsTbl> BonusPaymentsTbl { get; set; }
        public virtual ICollection<BonusRangesTbl> BonusRangesTbl { get; set; }
        public virtual ICollection<BonusTransactionDetailsTbl> BonusTransactionDetailsTbl { get; set; }
    }
}
