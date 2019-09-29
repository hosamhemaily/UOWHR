using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeMonthlySalaryTbl
    {
        public long EmployeeMonthlySalaryId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public double? TotalPayments { get; set; }
        public double? TotalDeductions { get; set; }
        public double? TotalLoans { get; set; }
        public double? FixedInsuranceAmount { get; set; }
        public double? VariableInsuranceAmount { get; set; }
        public double? AverageServiceChargeInPastYearAmount { get; set; }
        public double? EmployeeFixedInsurance { get; set; }
        public double? EmployeeVariableInsurance { get; set; }
        public double? EmployeeFixedInsuranceByCurrency { get; set; }
        public double? EmployeeVariableInsuranceByCurrency { get; set; }
        public double? EmployeeFixedHealthInsurance { get; set; }
        public double? EmployeeVariableHealthInsurance { get; set; }
        public double? EmployeeFixedHealthInsuranceByCurrency { get; set; }
        public double? EmployeeVariableHealthInsuranceByCurrency { get; set; }
        public double? CompanyFixedInsurance { get; set; }
        public double? CompanyVariableInsurance { get; set; }
        public double? CompanyFixedHealthInsurance { get; set; }
        public double? CompanyVariableHealthInsurance { get; set; }
        public double? TotalEmployeeInsurance { get; set; }
        public double? TotalEmployeeInsuranceByCurrency { get; set; }
        public double? TotalCompanyInsurance { get; set; }
        public double? TotalTaxablePayments { get; set; }
        public double? TotalTaxableDeductions { get; set; }
        public double? LifeInsuranceAmount { get; set; }
        public double? TaxExcemption { get; set; }
        public double? SpecialExcemption { get; set; }
        public double? TaxPool { get; set; }
        public double? SalaryTax { get; set; }
        public double? TaxAdjustment { get; set; }
        public double? InsuranceAdjustment { get; set; }
        public double? NetSalary { get; set; }
        public double? AdditionalPaymentsTax { get; set; }
        public double? BonusTax { get; set; }
        public double? ProfitTax { get; set; }
        public int? WorkingDays { get; set; }
        public double? WorkingHours { get; set; }
        public long? PropertyId { get; set; }
        public long? DivisionId { get; set; }
        public long? DepartmentId { get; set; }
        public long? SectionId { get; set; }
        public long? PositionId { get; set; }
        public long? CurrencyId { get; set; }
        public byte? SalaryCalculationWayId { get; set; }
        public long? TaxRuleId { get; set; }
        public byte? WorkInGovernmentTypeId { get; set; }
        public long? MaritalStatusId { get; set; }
        public bool? InsuranceYn { get; set; }
        public long? InsuranceRuleId { get; set; }
        public byte? ServiceChargeStatusId { get; set; }
        public bool? LifeInsuranceYn { get; set; }
        public bool? CompanyDefrayInsuranceYn { get; set; }
        public int? EmployeeStatusId { get; set; }
        public bool? ActiveYn { get; set; }
        public double? DifferenceTax { get; set; }

        public virtual CurrencyTbl Currency { get; set; }
        public virtual DepartmentTbl Department { get; set; }
        public virtual DivisionTbl Division { get; set; }
        public virtual EmployeeTbl Employee { get; set; }
        public virtual InsuranceRuleTbl InsuranceRule { get; set; }
        public virtual MaritalStatusTbl MaritalStatus { get; set; }
        public virtual PositionTbl Position { get; set; }
        public virtual PropertyTbl Property { get; set; }
        public virtual SalaryCalculationWayTbl SalaryCalculationWay { get; set; }
        public virtual SectionTbl Section { get; set; }
        public virtual ServiceChargeStatusTbl ServiceChargeStatus { get; set; }
        public virtual TaxRuleTbl TaxRule { get; set; }
        public virtual WorkInGovernmentTypeTbl WorkInGovernmentType { get; set; }
    }
}
