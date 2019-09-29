using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ChangeOfSalaryDetailsTbl
    {
        public long ChangeOfSalaryDetailsId { get; set; }
        public long ChangeOfStatusTransactionId { get; set; }
        public long? PaymentId { get; set; }
        public byte? ChangeTypeId { get; set; }
        public double? ChangeAmount { get; set; }
        public double? OldValue { get; set; }
        public bool? OldNetYn { get; set; }
        public double? NewValue { get; set; }
        public bool? NewNetYn { get; set; }
        public double? PercentageDeductedValue { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? ApplyRetroactivelyYn { get; set; }
        public int? RetroactiveMonthId { get; set; }
        public long? RetroactivePaymentId { get; set; }
        public double? OldValueAfterCalc { get; set; }
        public double? NewValueAfterCalc { get; set; }

        public virtual ChangeOfStatusTransactionTbl ChangeOfStatusTransaction { get; set; }
        public virtual ChangeTypeTbl ChangeType { get; set; }
        public virtual PaymentTbl Payment { get; set; }
    }
}
