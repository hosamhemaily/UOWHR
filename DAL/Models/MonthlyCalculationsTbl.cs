using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MonthlyCalculationsTbl
    {
        public long MonthlyCalculationsId { get; set; }
        public long? PropertyId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public bool? VacationCalculationYn { get; set; }
        public bool? TransferDataYn { get; set; }
        public bool? SalaryCalculationYn { get; set; }
        public bool? ServiceChargeCalculationYn { get; set; }
        public bool? ExportJvYn { get; set; }
        public bool? TaxBalanceYn { get; set; }
        public bool? PaidYn { get; set; }
        public bool? LockSelfServiceYn { get; set; }
    }
}
