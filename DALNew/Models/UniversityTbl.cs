using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UniversityTbl
    {
        public UniversityTbl()
        {
            EmployeeQualificationTbl = new HashSet<EmployeeQualificationTbl>();
        }

        public long UniversityId { get; set; }
        public long? PropertyId { get; set; }
        public string UniversityCode { get; set; }
        public string UniversityEnName { get; set; }
        public string UniversityArName { get; set; }
        public string UniversityArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeQualificationTbl> EmployeeQualificationTbl { get; set; }
    }
}
