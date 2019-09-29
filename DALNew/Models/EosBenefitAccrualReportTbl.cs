using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EosBenefitAccrualReportTbl
    {
        public long EosBenefitAccrualReportId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? EmployeeId { get; set; }
        public int? ServiceYears { get; set; }
        public int? ServiceMonths { get; set; }
        public double? TheAmount { get; set; }
    }
}
