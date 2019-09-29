using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class PrefixTbl
    {
        public PrefixTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long PrefixId { get; set; }
        public long? PropertyId { get; set; }
        public string PrefixCode { get; set; }
        public string PrefixEnName { get; set; }
        public string PrefixArName { get; set; }
        public string PrefixArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
