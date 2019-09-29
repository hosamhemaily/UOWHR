using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AttendanceCalculatedDataDetailsTbl
    {
        public long AttendanceCalculatedDataDetailsId { get; set; }
        public long? AttendanceCalculatedDataId { get; set; }
        public int? ShiftOrder { get; set; }
        public TimeSpan? TimeIn { get; set; }
        public TimeSpan? TimeOut { get; set; }
        public string ShiftStatus { get; set; }
        public bool? InWithoutOutYn { get; set; }
        public bool? OutWithoutInYn { get; set; }
        public bool? EarlyArrivalYn { get; set; }
        public int? EarlyArrivalH { get; set; }
        public int? EarlyArrivalM { get; set; }
        public bool? LateTimeYn { get; set; }
        public int? LateTimeH { get; set; }
        public int? LateTimeM { get; set; }
        public bool? EarlyDepartureYn { get; set; }
        public int? EarlyDepartureH { get; set; }
        public int? EarlyDepartureM { get; set; }
        public bool? OverTimeYn { get; set; }
        public int? OverTimeH { get; set; }
        public int? OverTimeM { get; set; }
        public bool? LatePermissionYn { get; set; }
        public bool? LeavePermissionYn { get; set; }
        public bool? EarlyMissionYn { get; set; }
        public bool? LateMissionYn { get; set; }
        public int? TotalHours { get; set; }
        public int? TotalMinutes { get; set; }
        public int? ExceptionHours { get; set; }
        public int? ExceptionMinutes { get; set; }
        public bool? BusDelayYn { get; set; }

        public virtual AttendanceCalculatedDataTbl AttendanceCalculatedData { get; set; }
    }
}
