using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmployeeDailySchedulesTbl
    {
        public long EmployeeDailySchedulesId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? TheDate { get; set; }
        public byte? DayStatusWorkingDayoff { get; set; }
        public int? ScheduleOrder { get; set; }
        public long? ScheduleId { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int? PassIn { get; set; }
        public int? OverTimeStart { get; set; }
        public bool? NightShiftYn { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
