using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ChangeTypeTbl
    {
        public ChangeTypeTbl()
        {
            ChangeOfSalaryDetailsTbl = new HashSet<ChangeOfSalaryDetailsTbl>();
        }

        public byte ChangeTypeId { get; set; }
        public string ChangeTypeEnName { get; set; }
        public string ChangeTypeArName { get; set; }

        public virtual ICollection<ChangeOfSalaryDetailsTbl> ChangeOfSalaryDetailsTbl { get; set; }
    }
}
