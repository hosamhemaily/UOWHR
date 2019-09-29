using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PaymentTransactionTbl
    {
        public long PaymentTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? PaymentId { get; set; }
        public double? PaymentValueBeforeCalc { get; set; }
        public double? CalculateFromValueTaxable { get; set; }
        public double? CalculateFromValueNonTaxable { get; set; }
        public double? PaymentValueAfterCalc { get; set; }
        public double? PaymentValueByLocalCurrency { get; set; }
        public bool? NetYn { get; set; }
        public double? PaymentNetValue { get; set; }
        public bool? ActiveYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public double? CalculateFromValueSc { get; set; }
        public double? CalculateFromValueNonSc { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual PaymentTbl Payment { get; set; }
    }
}
