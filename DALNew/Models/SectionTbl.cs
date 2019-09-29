using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SectionTbl
    {
        public SectionTbl()
        {
            EmployeeCostCenterTbl = new HashSet<EmployeeCostCenterTbl>();
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long SectionId { get; set; }
        public long? PropertyId { get; set; }
        public long? DivisionId { get; set; }
        public long? DepartmentId { get; set; }
        public string SectionCode { get; set; }
        public string SectionEnName { get; set; }
        public string SectionArName { get; set; }
        public string SectionArNameShadow { get; set; }
        public string SectionCostCenter { get; set; }
        public long? SectionMgrId { get; set; }
        public long? SectionSecId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeCostCenterTbl> EmployeeCostCenterTbl { get; set; }
        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
