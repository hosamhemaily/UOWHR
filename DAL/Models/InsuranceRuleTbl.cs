using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class InsuranceRuleTbl
    {
        public InsuranceRuleTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long InsuranceRuleId { get; set; }
        public long? PropertyId { get; set; }
        public string InsuranceRuleCode { get; set; }
        public string InsuranceRuleEnName { get; set; }
        public string InsuranceRuleArName { get; set; }
        public string InsuranceRuleArNameShadow { get; set; }
        public bool? CalculateFromFixedAmounts { get; set; }
        public double? EmployeeFixedInsuranceRate { get; set; }
        public double? EmployeeVariableInsuranceRate { get; set; }
        public double? EmployeeFixedHealthInsuranceRate { get; set; }
        public double? EmployeeVariableHealthInsuranceRate { get; set; }
        public double? OrganizationFixedInsuranceRate { get; set; }
        public double? OrganizationVariableInsuranceRate { get; set; }
        public double? OrganizationFixedHealthInsuranceRate { get; set; }
        public double? OrganizationVariableHealthInsuranceRate { get; set; }
        public double? FixedInsuranceMaximumLimit { get; set; }
        public double? VariableInsuranceMaximumLimit { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
