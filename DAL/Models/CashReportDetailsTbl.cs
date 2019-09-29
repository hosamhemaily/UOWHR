using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CashReportDetailsTbl
    {
        public long CashReportDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public double? Value { get; set; }
        public long? CurrencyId { get; set; }
    }
}
