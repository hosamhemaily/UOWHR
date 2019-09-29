using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AttendanceCalculatedDataTbl
    {
        public AttendanceCalculatedDataTbl()
        {
            AttendanceCalculatedDataDetailsTbl = new HashSet<AttendanceCalculatedDataDetailsTbl>();
        }

        public long AttendanceCalculatedDataId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? TheDate { get; set; }
        public bool? FromMachineYn { get; set; }
        public string Abbreviation { get; set; }
        public string DayStatus { get; set; }
        public string HrDayStatus { get; set; }
        public int? TotalHours { get; set; }
        public int? TotalMinutes { get; set; }
        public int? RequiredHours { get; set; }
        public int? RequiredMinutes { get; set; }

        public virtual ICollection<AttendanceCalculatedDataDetailsTbl> AttendanceCalculatedDataDetailsTbl { get; set; }
    }
}
