using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualificationTypeTbl
    {
        public QualificationTypeTbl()
        {
            QualificationTbl = new HashSet<QualificationTbl>();
        }

        public long QualificationTypeId { get; set; }
        public long? PropertyId { get; set; }
        public string QualificationTypeCode { get; set; }
        public string QualificationTypeEnName { get; set; }
        public string QualificationTypeArName { get; set; }
        public string QualificationTypeArNameShadow { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<QualificationTbl> QualificationTbl { get; set; }
    }
}
