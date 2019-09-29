using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualificationTbl
    {
        public QualificationTbl()
        {
            EmployeeQualificationTbl = new HashSet<EmployeeQualificationTbl>();
        }

        public long QualificationId { get; set; }
        public long? PropertyId { get; set; }
        public string QualificationCode { get; set; }
        public string QualificationEnName { get; set; }
        public string QualificationArName { get; set; }
        public string QualificationArNameShadow { get; set; }
        public long? QualificationTypeId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual QualificationTypeTbl QualificationType { get; set; }
        public virtual ICollection<EmployeeQualificationTbl> EmployeeQualificationTbl { get; set; }
    }
}
