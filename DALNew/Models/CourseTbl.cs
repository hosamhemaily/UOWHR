using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CourseTbl
    {
        public CourseTbl()
        {
            CourseTransactionTbl = new HashSet<CourseTransactionTbl>();
        }

        public long CourseId { get; set; }
        public long? PropertyId { get; set; }
        public string CourseCode { get; set; }
        public string CourseEnName { get; set; }
        public string CourseArName { get; set; }
        public string CourseArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<CourseTransactionTbl> CourseTransactionTbl { get; set; }
    }
}
