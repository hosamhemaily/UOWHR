using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VacationRuleAgeYearsTbl
    {
        public long VacationRuleAgeYearsId { get; set; }
        public long VacationRuleId { get; set; }
        public int? UpToYears { get; set; }
        public double? VacationCategoryRate { get; set; }

        public virtual VacationRuleTbl VacationRule { get; set; }
    }
}
