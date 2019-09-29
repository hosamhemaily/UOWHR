using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AdditionalPaymentTransactionDetailsTbl
    {
        public long AdditionalPaymentTransactionDetailsId { get; set; }
        public long? AdditionalPaymentTransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public double? PaymentValueBeforeCalc { get; set; }
        public double? PaymentTax { get; set; }
        public double? PaymentValueAfterCalc { get; set; }
        public double? PaymentNetValue { get; set; }
        public long? CurrencyId { get; set; }
        public bool? TaxableYn { get; set; }
        public bool? ActiveYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual AdditionalPaymentTransactionTbl AdditionalPaymentTransaction { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
