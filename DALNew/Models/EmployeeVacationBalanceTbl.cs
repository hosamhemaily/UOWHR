using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeVacationBalanceTbl
    {
        public long EmployeeVacationBalanceId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public double? AnnualOpeningBalance { get; set; }
        public double? AnnualDueBalance { get; set; }
        public double? AnnualConsumption { get; set; }
        public double? AnnualOtherConsumption { get; set; }
        public double? AnnualHolidayDeduction { get; set; }
        public double? AnnualBalance { get; set; }
        public double? DayOffOpeningBalance { get; set; }
        public double? DayOffDueBalance { get; set; }
        public double? DayOffConsumption { get; set; }
        public double? DayOffOtherConsumption { get; set; }
        public double? DayOffHolidayDeduction { get; set; }
        public double? DayOffBalance { get; set; }
        public double? HolidayOpeningBalance { get; set; }
        public double? HolidayDueBalance { get; set; }
        public double? HolidayConsumption { get; set; }
        public double? HolidayOtherConsumption { get; set; }
        public double? HolidayHolidayDeduction { get; set; }
        public double? HolidayBalance { get; set; }
        public double? RemoteOpeningBalance { get; set; }
        public double? RemoteDueBalance { get; set; }
        public double? RemoteConsumption { get; set; }
        public double? RemoteOtherConsumption { get; set; }
        public double? RemoteHolidayDeduction { get; set; }
        public double? RemoteBalance { get; set; }
    }
}
