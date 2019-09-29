using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class TerminationTransactionTbl
    {
        public long TerminationTransactionId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? OldEmployeeStatusId { get; set; }
        public DateTime? TerminationDate { get; set; }
        public long? TerminationReasonId { get; set; }
        public bool? ReturnYn { get; set; }
        public double? VacationBalance { get; set; }
        public bool? AfterCloseMonthYn { get; set; }
        public bool? UseInsuranceYn { get; set; }
        public bool? UseLifeInsuranceYn { get; set; }
        public string Notes { get; set; }
        public DateTime? PreviousHiringDate { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }
        public double? DayOffBalance { get; set; }
        public double? HolidayBalance { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
        public virtual TerminationReasonTbl TerminationReason { get; set; }
    }
}
