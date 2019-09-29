using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AttendanceAbsencePenaltyTbl
    {
        public long AttendanceAbsencePenaltyId { get; set; }
        public long? AttendanceRuleId { get; set; }
        public double? FromDay { get; set; }
        public double? ToDay { get; set; }
        public double? PenaltyDays { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual AttendanceRuleTbl AttendanceRule { get; set; }
    }
}
