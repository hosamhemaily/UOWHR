using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class DeductionTbl
    {
        public DeductionTbl()
        {
            BonusDeductionsTbl = new HashSet<BonusDeductionsTbl>();
            DeductionDetailsTbl = new HashSet<DeductionDetailsTbl>();
            DeductionTransactionTbl = new HashSet<DeductionTransactionTbl>();
            VacationDeductionInterfaceTbl = new HashSet<VacationDeductionInterfaceTbl>();
            VacationRangeDeductionTbl = new HashSet<VacationRangeDeductionTbl>();
        }

        public long DeductionId { get; set; }
        public long? PropertyId { get; set; }
        public string DeductionCode { get; set; }
        public string DeductionEnName { get; set; }
        public string DeductionEnShortName { get; set; }
        public string DeductionArName { get; set; }
        public string DeductionArNameShadow { get; set; }
        public string DeductionArShortName { get; set; }
        public long? AccountNumberId { get; set; }
        public byte? DeductionTypeId { get; set; }
        public byte? DeductionStatusId { get; set; }
        public double? MinimumAmount { get; set; }
        public double? MaximumAmount { get; set; }
        public bool? FixedAmountYn { get; set; }
        public double? DaysHoursFactor { get; set; }
        public byte? SelectionGroupPayment { get; set; }
        public long? PaymentGroupId { get; set; }
        public byte? DeductionContinuity { get; set; }
        public bool? TaxableYn { get; set; }
        public bool? EffectInServiceChargeYn { get; set; }
        public bool? ActiveYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? InterfaceYn { get; set; }

        public virtual AccountNumberTbl AccountNumber { get; set; }
        public virtual PaymentGroupTbl PaymentGroup { get; set; }
        public virtual ICollection<BonusDeductionsTbl> BonusDeductionsTbl { get; set; }
        public virtual ICollection<DeductionDetailsTbl> DeductionDetailsTbl { get; set; }
        public virtual ICollection<DeductionTransactionTbl> DeductionTransactionTbl { get; set; }
        public virtual ICollection<VacationDeductionInterfaceTbl> VacationDeductionInterfaceTbl { get; set; }
        public virtual ICollection<VacationRangeDeductionTbl> VacationRangeDeductionTbl { get; set; }
    }
}
