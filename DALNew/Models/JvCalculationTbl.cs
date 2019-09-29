using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class JvCalculationTbl
    {
        public long JvCalculationId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? PropertyId { get; set; }
        public long? DivisionId { get; set; }
        public long? DepartmentId { get; set; }
        public long? SectionId { get; set; }
        public long? EmployeeId { get; set; }
        public string AccountNumber { get; set; }
        public string JornalType { get; set; }
        public double? Amount { get; set; }
        public string AmountType { get; set; }
        public string PropertyCostCenter { get; set; }
        public string DivisionCostCenter { get; set; }
        public string DepartmentCostCenter { get; set; }
        public string SectionCostCenter { get; set; }
        public string GradeCostCenter { get; set; }
        public string AccountNumberJvDescription { get; set; }
        public bool? SettlementYn { get; set; }
        public DateTime? JvDate { get; set; }
        public string JvType { get; set; }
        public byte? EmployeeStatus { get; set; }
        public string OtherHierarchyCostCenter { get; set; }
        public string OtherHierarchyTCode { get; set; }
        public string ManegerialCostCenter { get; set; }
        public string ManegerialTCode { get; set; }
        public string EmployeeCostCenter { get; set; }
    }
}
