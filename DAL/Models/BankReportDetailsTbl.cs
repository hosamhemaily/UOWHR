using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BankReportDetailsTbl
    {
        public long BankReportDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public long? BankId { get; set; }
        public string BankBranchNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankEmployeeNumber { get; set; }
        public double? Value { get; set; }
        public long? CurrencyId { get; set; }
        public bool? WbsYn { get; set; }
    }
}
