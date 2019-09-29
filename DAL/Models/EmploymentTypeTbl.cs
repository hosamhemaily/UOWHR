using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class EmploymentTypeTbl
    {
        public EmploymentTypeTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte EmploymentTypeId { get; set; }
        public string EmploymentTypeEnName { get; set; }
        public string EmploymentTypeArName { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
