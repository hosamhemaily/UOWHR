using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ComparisionReportDetailsTbl
    {
        public long ComparisionReportDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public int? FirstYear { get; set; }
        public int? FirstMonth { get; set; }
        public double? FirstTotalPayments { get; set; }
        public double? FirstTotalDeductions { get; set; }
        public double? FirstTaxAdjustment { get; set; }
        public double? FirstInsuranceAdjustment { get; set; }
        public double? FirstSalaryTax { get; set; }
        public double? FirstInsurance { get; set; }
        public double? FirstNet { get; set; }
        public double? FirstServiceChargeValue { get; set; }
        public double? FirstServiceChargeTax { get; set; }
        public double? FirstServiceChargeNet { get; set; }
        public int? SecondYear { get; set; }
        public int? SecondMonth { get; set; }
        public double? SecondTotalPayments { get; set; }
        public double? SecondTotalDeductions { get; set; }
        public double? SecondTaxAdjustment { get; set; }
        public double? SecondInsuranceAdjustment { get; set; }
        public double? SecondSalaryTax { get; set; }
        public double? SecondInsurance { get; set; }
        public double? SecondNet { get; set; }
        public double? SecondServiceChargeValue { get; set; }
        public double? SecondServiceChargeTax { get; set; }
        public double? SecondServiceChargeNet { get; set; }
    }
}
