using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DepartmentTbl
    {
        public DepartmentTbl()
        {
            EmployeeCostCenterTbl = new HashSet<EmployeeCostCenterTbl>();
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long DepartmentId { get; set; }
        public long? PropertyId { get; set; }
        public long? DivisionId { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentEnName { get; set; }
        public string DepartmentArName { get; set; }
        public string DepartmentArNameShadow { get; set; }
        public string DepartmentCostCenter { get; set; }
        public long? DepartmentMgrId { get; set; }
        public long? DepartmentSecId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeCostCenterTbl> EmployeeCostCenterTbl { get; set; }
        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
