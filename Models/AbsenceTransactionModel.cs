using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class AbsenceTransactionModel :CommonPropModel
    {
        public long AbsenceTransactionId { get; set; }
        public string AttendanceTypeId { get; set; }
        public long? PropertyId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public int? SysRequestStatusId { get; set; }

        public EmployeeModel Employee { get; set; }

        public SysRequestStatusModel SysRequestStatus { get; set; }
    }
}
