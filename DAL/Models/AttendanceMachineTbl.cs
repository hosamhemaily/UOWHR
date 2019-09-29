using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AttendanceMachineTbl
    {
        public AttendanceMachineTbl()
        {
            AttendanceMachineDetailsTbl = new HashSet<AttendanceMachineDetailsTbl>();
        }

        public long AttendanceMachineId { get; set; }
        public long? PropertyId { get; set; }
        public string AttendanceMachineCode { get; set; }
        public string AttendanceMachineEnName { get; set; }
        public string AttendanceMachineArName { get; set; }
        public string AttendanceMachineArNameShadow { get; set; }
        public int? AttendanceMachineTerminalId { get; set; }
        public string CheckInFlag { get; set; }
        public string CheckOutFlag { get; set; }
        public bool? UseBreakYn { get; set; }
        public string BreakInFlag { get; set; }
        public string BreakOutFlag { get; set; }
        public bool? UseMissionYn { get; set; }
        public string MissionInFlag { get; set; }
        public string MissionOutFlag { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<AttendanceMachineDetailsTbl> AttendanceMachineDetailsTbl { get; set; }
    }
}
