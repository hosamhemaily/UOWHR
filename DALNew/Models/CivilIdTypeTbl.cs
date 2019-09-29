using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CivilIdTypeTbl
    {
        public CivilIdTypeTbl()
        {
            EmployeeRelativeTbl = new HashSet<EmployeeRelativeTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte CivilIdTypeId { get; set; }
        public string CivilIdTypeEnName { get; set; }
        public string CivilIdTypeArName { get; set; }

        public virtual ICollection<EmployeeRelativeTbl> EmployeeRelativeTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
