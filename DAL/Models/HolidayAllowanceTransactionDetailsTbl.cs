using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HolidayAllowanceTransactionDetailsTbl
    {
        public long HolidayAllowanceTransactionDetailsId { get; set; }
        public long HolidayAllowanceTransactionId { get; set; }
        public long? EmployeeId { get; set; }
        public long? AlternativeVacationTransactionId { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual EmployeeTbl Employee { get; set; }
        public virtual HolidayAllowanceTransactionTbl HolidayAllowanceTransaction { get; set; }
    }
}
