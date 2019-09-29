using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class VacationCategoryTbl
    {
        public VacationCategoryTbl()
        {
            VacationBalanceTbl = new HashSet<VacationBalanceTbl>();
            VacationTypeTbl = new HashSet<VacationTypeTbl>();
        }

        public byte VacationCategoryId { get; set; }
        public string VacationCategoryEnName { get; set; }
        public string VacationCategoryArName { get; set; }

        public virtual ICollection<VacationBalanceTbl> VacationBalanceTbl { get; set; }
        public virtual ICollection<VacationTypeTbl> VacationTypeTbl { get; set; }
    }
}
