using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class GenderTbl
    {
        public GenderTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte GenderId { get; set; }
        public string GenderEnName { get; set; }
        public string GenderArName { get; set; }

        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
