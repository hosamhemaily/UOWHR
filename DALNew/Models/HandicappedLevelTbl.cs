using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HandicappedLevelTbl
    {
        public HandicappedLevelTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long HandicappedLevelId { get; set; }
        public long? PropertyId { get; set; }
        public string HandicappedLevelCode { get; set; }
        public string HandicappedLevelEnName { get; set; }
        public string HandicappedLevelArName { get; set; }
        public string HandicappedLevelArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
