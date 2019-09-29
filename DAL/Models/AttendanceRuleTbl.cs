using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AttendanceRuleTbl
    {
        public AttendanceRuleTbl()
        {
            AttendanceAbsencePenaltyTbl = new HashSet<AttendanceAbsencePenaltyTbl>();
            AttendanceLatePenaltyTbl = new HashSet<AttendanceLatePenaltyTbl>();
            AttendanceLateTransactionTbl = new HashSet<AttendanceLateTransactionTbl>();
            AttendanceOverTimeTransactionTbl = new HashSet<AttendanceOverTimeTransactionTbl>();
            EmployeeTbl = new HashSet<EmployeeTbl>();
        }

        public long AttendanceRuleId { get; set; }
        public long? PropertyId { get; set; }
        public string AttendanceRuleCode { get; set; }
        public string AttendanceRuleEnName { get; set; }
        public string AttendanceRuleArName { get; set; }
        public string AttendanceRuleArNameShadow { get; set; }
        public byte? AttendanceType { get; set; }
        public long? ScheduleId { get; set; }
        public int? DailyHours { get; set; }
        public byte? CalculationWay { get; set; }
        public bool? UseLateTransactionYn { get; set; }
        public bool? UseLatePenaltyYn { get; set; }
        public bool? UseAbsenceTransactionYn { get; set; }
        public bool? UseAbsencePenaltyYn { get; set; }
        public bool? UseOverTimeTransactionYn { get; set; }
        public byte? AbsencePenaltyDays { get; set; }
        public byte? LateTransactionSlicesDailyMonthly { get; set; }
        public byte? LatePenaltySlicesDailyMonthly { get; set; }
        public byte? OverTimeSlicesDailyMonthly { get; set; }
        public byte? InWithoutOutAbsencePenalty { get; set; }
        public double? InWithoutOutPenaltyDays { get; set; }
        public byte? OutWithoutInAbsencePenalty { get; set; }
        public double? OutWithoutInPenaltyDays { get; set; }
        public long? FormId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public int? MinShiftsForPresent { get; set; }

        public virtual ScheduleTbl Schedule { get; set; }
        public virtual ICollection<AttendanceAbsencePenaltyTbl> AttendanceAbsencePenaltyTbl { get; set; }
        public virtual ICollection<AttendanceLatePenaltyTbl> AttendanceLatePenaltyTbl { get; set; }
        public virtual ICollection<AttendanceLateTransactionTbl> AttendanceLateTransactionTbl { get; set; }
        public virtual ICollection<AttendanceOverTimeTransactionTbl> AttendanceOverTimeTransactionTbl { get; set; }
        public virtual ICollection<EmployeeTbl> EmployeeTbl { get; set; }
    }
}
