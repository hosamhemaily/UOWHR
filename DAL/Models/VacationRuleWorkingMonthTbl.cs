using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VacationRuleWorkingMonthTbl
    {
        public long VacationRuleWorkingMonthId { get; set; }
        public long VacationRuleId { get; set; }
        public int? UpToMonths { get; set; }
        public double? VacationCategoryRate { get; set; }

        public virtual VacationRuleTbl VacationRule { get; set; }
    }
}
