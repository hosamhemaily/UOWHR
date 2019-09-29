using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ServiceChargeTransactionDetailsTbl
    {
        public long ServiceChargeTransactionDetailsId { get; set; }
        public long? ServiceChargeTransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public double? ServiceChargePool { get; set; }
        public double? ServiceChargeValue { get; set; }
        public double? ServiceChargePayments { get; set; }
        public double? ServiceChargeTax { get; set; }
        public double? ServiceChargeDeduction { get; set; }
        public double? NetServiceCharge { get; set; }
        public double? EmployeeNet { get; set; }
        public double? ServiceChargeTaxablePayments { get; set; }
        public double? ServiceChargeTaxableDeductions { get; set; }
        public long? CurrencyId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual ServiceChargeTransactionTbl ServiceChargeTransaction { get; set; }
    }
}
