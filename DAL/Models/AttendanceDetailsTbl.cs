using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AttendanceDetailsTbl
    {
        public long AttendanceDetailsId { get; set; }
        public long? MasterId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? EmployeeId { get; set; }
        public long? VacationTypeId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public string Abbreviation { get; set; }
        public bool? AlternativeHolidayYn { get; set; }
        public long? HolidayId { get; set; }
        public double? AnnualConsumption { get; set; }
        public double? DayOffConsumption { get; set; }
        public double? HolidayConsumption { get; set; }
        public double? RemoteConsumption { get; set; }
        public bool? SecondDayOffOtherConsumption { get; set; }
        public long? FormId { get; set; }
    }
}
