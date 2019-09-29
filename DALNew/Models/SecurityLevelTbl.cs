using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SecurityLevelTbl
    {
        public SecurityLevelTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte SecurityLevelId { get; set; }
        public string SecurityLevelEnName { get; set; }
        public string SecurityLevelArName { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
