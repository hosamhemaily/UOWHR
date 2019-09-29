using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class BloodTypeTbl
    {
        public BloodTypeTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte BloodTypeId { get; set; }
        public string BloodTypeEnName { get; set; }
        public string BloodTypeArName { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
