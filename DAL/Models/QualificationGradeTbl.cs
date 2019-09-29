using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualificationGradeTbl
    {
        public QualificationGradeTbl()
        {
            EmployeeQualificationTbl = new HashSet<EmployeeQualificationTbl>();
        }

        public long QualificationGradeId { get; set; }
        public long? PropertyId { get; set; }
        public string QualificationGradeCode { get; set; }
        public string QualificationGradeEnName { get; set; }
        public string QualificationGradeArName { get; set; }
        public string QualificationGradeArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeQualificationTbl> EmployeeQualificationTbl { get; set; }
    }
}
