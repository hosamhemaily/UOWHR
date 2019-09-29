using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VacationBalanceDetailsTbl
    {
        public long VacationBalanceDetailsId { get; set; }
        public long? VacationBalanceId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? VacationRuleId { get; set; }
        public double? VacationDueBalance { get; set; }
        public double? Consumption { get; set; }
        public double? OtherConsumption { get; set; }
        public double? HolidayDeduction { get; set; }
        public double? LimitConsumption { get; set; }
        public double? PaidConsumption { get; set; }
        public double? Balance { get; set; }

        public virtual VacationBalanceTbl VacationBalance { get; set; }
        public virtual VacationRuleTbl VacationRule { get; set; }
    }
}
