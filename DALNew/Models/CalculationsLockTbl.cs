using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class CalculationsLockTbl
    {
        public int CalculationsLockId { get; set; }
        public long? PropertyId { get; set; }
        public bool? TransferLockYn { get; set; }
        public bool? SalaryCalculationLockYn { get; set; }
        public bool? ServiceChargeCalculationLockYn { get; set; }
        public bool? ExportJvLockYn { get; set; }
        public bool? TaxBalanceLockYn { get; set; }
        public bool? VacationCalculationLockYn { get; set; }
        public bool? NewMonthLockYn { get; set; }
        public bool? AttendanceCalculationYn { get; set; }
        public bool? TransferAttendanceDataYn { get; set; }
        public bool? PercentileCalculationYn { get; set; }
    }
}
