using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PositionTbl
    {
        public PositionTbl()
        {
            EmployeeMonthlySalaryTbl = new HashSet<EmployeeMonthlySalaryTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
            JobDescriptionTbl = new HashSet<JobDescriptionTbl>();
            PositionConfigurationTbl = new HashSet<PositionConfigurationTbl>();
        }

        public long PositionId { get; set; }
        public long? PropertyId { get; set; }
        public string PositionCode { get; set; }
        public string PositionEnName { get; set; }
        public string PositionArName { get; set; }
        public string PositionArNameShadow { get; set; }
        public long? GradeId { get; set; }
        public long? PositionTypeId { get; set; }
        public bool? ManagerYn { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual GradeTbl Grade { get; set; }
        public virtual PositionTypeTbl PositionType { get; set; }
        public virtual ICollection<EmployeeMonthlySalaryTbl> EmployeeMonthlySalaryTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
        public virtual ICollection<JobDescriptionTbl> JobDescriptionTbl { get; set; }
        public virtual ICollection<PositionConfigurationTbl> PositionConfigurationTbl { get; set; }
    }
}
