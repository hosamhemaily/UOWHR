using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PaymentTbl
    {
        public PaymentTbl()
        {
            AdditionalPaymentTransactionTbl = new HashSet<AdditionalPaymentTransactionTbl>();
            BonusPaymentsTbl = new HashSet<BonusPaymentsTbl>();
            BonusTransactionTbl = new HashSet<BonusTransactionTbl>();
            ChangeOfSalaryDetailsTbl = new HashSet<ChangeOfSalaryDetailsTbl>();
            PaymentDetailsTbl = new HashSet<PaymentDetailsTbl>();
            PaymentGroupDetailsTbl = new HashSet<PaymentGroupDetailsTbl>();
            PaymentTransactionTbl = new HashSet<PaymentTransactionTbl>();
        }

        public long PaymentId { get; set; }
        public long? PropertyId { get; set; }
        public string PaymentCode { get; set; }
        public string PaymentEnName { get; set; }
        public string PaymentEnShortName { get; set; }
        public string PaymentArName { get; set; }
        public string PaymentArNameShadow { get; set; }
        public string PaymentArShortName { get; set; }
        public long? AccountNumberId { get; set; }
        public byte? PaymentTypeId { get; set; }
        public byte? PaymentStatusId { get; set; }
        public double? MinimumAmount { get; set; }
        public double? MaximumAmount { get; set; }
        public bool? FixedAmountYn { get; set; }
        public double? DaysHoursFactor { get; set; }
        public byte? SelectionGroupPayment { get; set; }
        public long? PaymentGroupId { get; set; }
        public byte? PaymentContinuity { get; set; }
        public bool? TaxableYn { get; set; }
        public byte? InsuranceStatusId { get; set; }
        public bool? EffectInServiceChargeYn { get; set; }
        public bool? BasicPaymentYn { get; set; }
        public bool? AddToBasicYn { get; set; }
        public int? AddToBasicInYear { get; set; }
        public int? AddToBasicInMonth { get; set; }
        public bool? GrossSalaryYn { get; set; }
        public bool? HrControlYn { get; set; }
        public bool? ShowInPayslipYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? InterfaceYn { get; set; }

        public virtual AccountNumberTbl AccountNumber { get; set; }
        public virtual PaymentGroupTbl PaymentGroup { get; set; }
        public virtual PaymentStatusTbl PaymentStatus { get; set; }
        public virtual PaymentTypeTbl PaymentType { get; set; }
        public virtual ICollection<AdditionalPaymentTransactionTbl> AdditionalPaymentTransactionTbl { get; set; }
        public virtual ICollection<BonusPaymentsTbl> BonusPaymentsTbl { get; set; }
        public virtual ICollection<BonusTransactionTbl> BonusTransactionTbl { get; set; }
        public virtual ICollection<ChangeOfSalaryDetailsTbl> ChangeOfSalaryDetailsTbl { get; set; }
        public virtual ICollection<PaymentDetailsTbl> PaymentDetailsTbl { get; set; }
        public virtual ICollection<PaymentGroupDetailsTbl> PaymentGroupDetailsTbl { get; set; }
        public virtual ICollection<PaymentTransactionTbl> PaymentTransactionTbl { get; set; }
    }
}
