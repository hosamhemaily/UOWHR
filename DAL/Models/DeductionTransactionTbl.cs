using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DeductionTransactionTbl
    {
        public long DeductionTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? DeductionId { get; set; }
        public double? DeductionValueBeforeCalc { get; set; }
        public double? CalculateFromValueTaxable { get; set; }
        public double? CalculateFromValueNonTaxable { get; set; }
        public double? DeductionValueAfterCalc { get; set; }
        public double? DeductionValueByLocalCurrency { get; set; }
        public bool? ActiveYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public double? CalculateFromValueSc { get; set; }
        public double? CalculateFromValueNonSc { get; set; }

        public virtual DeductionTbl Deduction { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
    }
}
