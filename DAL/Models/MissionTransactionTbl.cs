using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MissionTransactionTbl
    {
        public long MissionTransactionId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public bool? FullDayYn { get; set; }
        public DateTime? FromDate { get; set; }
        public TimeSpan? FromTime { get; set; }
        public DateTime? ToDate { get; set; }
        public TimeSpan? ToTime { get; set; }
        public int? DaysNumber { get; set; }
        public bool? AbroadYn { get; set; }
        public string Destination { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }
        public int? OverlappingTypeId { get; set; }
        public long? IdBeforeDistribution { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
    }
}
