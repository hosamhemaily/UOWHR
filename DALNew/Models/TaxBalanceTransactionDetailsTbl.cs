using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TaxBalanceTransactionDetailsTbl
    {
        public long TaxBalanceTransactionDetailsId { get; set; }
        public long? TaxBalanceTransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public int? WorkingMonths { get; set; }
        public double? CalculatedTax { get; set; }
        public double? Difference { get; set; }
        public double? TotalPayments { get; set; }
        public double? TotalTaxablePayments { get; set; }
        public double? TotalTaxableDeductions { get; set; }
        public double? TaxExcemption { get; set; }
        public double? TotalEmployeeInsurance { get; set; }
        public double? LifeInsuranceAmount { get; set; }
        public double? MonthServiceChargePool { get; set; }
        public double? MonthAdditionalPaymentPool { get; set; }
        public double? MonthBonusPool { get; set; }
        public double? MonthProfitPool { get; set; }
        public double? CurrentTotalTax { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual TaxBalanceTransactionTbl TaxBalanceTransaction { get; set; }
    }
}
