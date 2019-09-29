using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class TaxRuleTbl
    {
        public TaxRuleTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long TaxRuleId { get; set; }
        public long? PropertyId { get; set; }
        public string TaxRuleCode { get; set; }
        public string TaxRuleEnName { get; set; }
        public string TaxRuleArName { get; set; }
        public string TaxRuleArNameShadow { get; set; }
        public bool? TaxableYn { get; set; }
        public bool? FixedSliceYn { get; set; }
        public double? SliceRate { get; set; }
        public bool? AllowExemptionYn { get; set; }
        public double? PersonalExemption { get; set; }
        public double? SingleExemption { get; set; }
        public double? MarriedExemption { get; set; }
        public double? MarriedWithChildrenExemption { get; set; }
        public double? SpecialExemption { get; set; }
        public bool? ProportionTheExemptionYn { get; set; }
        public bool? CalcPaymentsDeductionsDetailedYn { get; set; }
        public byte? TaxCaculationAlgorithm { get; set; }
        public string TaxFormula { get; set; }
        public int? GrossUpFormulaId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
