using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class HolidayAllowanceTypeTbl
    {
        public HolidayAllowanceTypeTbl()
        {
            HolidayAllowanceTransactionTbl = new HashSet<HolidayAllowanceTransactionTbl>();
        }

        public byte HolidayAllowanceTypeId { get; set; }
        public string HolidayAllowanceTypeEnName { get; set; }
        public string HolidayAllowanceTypeArName { get; set; }

        public virtual ICollection<HolidayAllowanceTransactionTbl> HolidayAllowanceTransactionTbl { get; set; }
    }
}
