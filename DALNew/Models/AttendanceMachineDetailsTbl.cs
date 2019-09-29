using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AttendanceMachineDetailsTbl
    {
        public long AttendanceMachineDetailsId { get; set; }
        public long? AttendanceMachineId { get; set; }
        public string CommunicationType { get; set; }
        public int? SysAttendanceMachineSdkId { get; set; }
        public string TcpIp { get; set; }
        public string TcpIpPort { get; set; }
        public string ConnectionPassword { get; set; }
        public bool? FileHeaderFirstRowYn { get; set; }
        public bool? FileDelimiterYn { get; set; }
        public string FileDelimiter { get; set; }
        public string FileDateFormat { get; set; }
        public bool? SeparateDateTimeYn { get; set; }
        public string DateOrder { get; set; }
        public int? DateLength { get; set; }
        public string TimeOrder { get; set; }
        public int? TimeLength { get; set; }
        public string EmployeeCodeOrder { get; set; }
        public int? EmployeeCodeLength { get; set; }
        public string FlagOrder { get; set; }
        public int? FlagLength { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public bool? MarkAsReadYn { get; set; }
        public string MarkAsReadOrder { get; set; }
        public string TableName { get; set; }

        public virtual AttendanceMachineTbl AttendanceMachine { get; set; }
    }
}
