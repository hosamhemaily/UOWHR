using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DivisionTbl
    {
        public DivisionTbl()
        {
            EmployeeCostCenterTbl = new HashSet<EmployeeCostCenterTbl>();
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long DivisionId { get; set; }
        public long? PropertyId { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionEnName { get; set; }
        public string DivisionArName { get; set; }
        public string DivisionArNameShadow { get; set; }
        public string DivisionCostCenter { get; set; }
        public long? DivisionMgrId { get; set; }
        public long? DivisionSecId { get; set; }
        public bool? DefaultYn { get; set; }
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
