using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class VacationTransactionTbl
    {
        public long VacationTransactionId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public long? VacationTypeId { get; set; }
        public DateTime? VacationRequestDate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? DaysNumber { get; set; }
        public bool? ByTransportationYn { get; set; }
        public bool? ThrowMachineYn { get; set; }
        public string AddressDuringThisVacation { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public int? SysRequestStatusId { get; set; }
        public double? CurrentBalance { get; set; }
        public double? PendingBalance { get; set; }
        public double? BalanceAfter { get; set; }
        public long? IdBeforeDistribution { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual SysRequestStatusTbl SysRequestStatus { get; set; }
        public virtual VacationTypeTbl VacationType { get; set; }
    }
}
