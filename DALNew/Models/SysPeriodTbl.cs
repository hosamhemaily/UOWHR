using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysPeriodTbl
    {
        public long Id { get; set; }
        public string PeriodCode { get; set; }
        public string PeriodEnName { get; set; }
        public string PeriodArName { get; set; }
    }
}
