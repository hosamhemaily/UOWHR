using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class DayOfTheWeekTbl
    {
        public DayOfTheWeekTbl()
        {
            VacationRuleTblFirstDayOff = new HashSet<VacationRuleTbl>();
            VacationRuleTblSecondDayOff = new HashSet<VacationRuleTbl>();
        }

        public byte DayOfTheWeekId { get; set; }
        public string DayOfTheWeekEnName { get; set; }
        public string DayOfTheWeekArName { get; set; }

        public virtual ICollection<VacationRuleTbl> VacationRuleTblFirstDayOff { get; set; }
        public virtual ICollection<VacationRuleTbl> VacationRuleTblSecondDayOff { get; set; }
    }
}
