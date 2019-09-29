using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ScheduleTbl
    {
        public ScheduleTbl()
        {
            AttendanceRuleTbl = new HashSet<AttendanceRuleTbl>();
        }

        public long ScheduleId { get; set; }
        public long? PropertyId { get; set; }
        public string ScheduleCode { get; set; }
        public string ScheduleEnName { get; set; }
        public string ScheduleArName { get; set; }
        public string ScheduleArNameShadow { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public int? PassIn { get; set; }
        public int? OverTimeStart { get; set; }
        public bool? NightShiftYn { get; set; }
        public string Abbreviation { get; set; }
        public string Color { get; set; }
        public long? FormId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }

        public virtual ICollection<AttendanceRuleTbl> AttendanceRuleTbl { get; set; }
    }
}
