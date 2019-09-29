using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HousingTypeTbl
    {
        public HousingTypeTbl()
        {
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public byte HousingTypeId { get; set; }
        public string HousingTypeEnName { get; set; }
        public string HousingTypeArName { get; set; }

        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
