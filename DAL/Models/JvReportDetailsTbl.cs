using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class JvReportDetailsTbl
    {
        public long JvReportDetailsId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public int? TheYear { get; set; }
        public int? TheMonth { get; set; }
        public string AccountNumber { get; set; }
        public string AccountNumberJvDescription { get; set; }
        public string JornalType { get; set; }
        public string JvType { get; set; }
        public double? AmountD { get; set; }
        public double? AmountC { get; set; }
        public string T0 { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
        public string T5 { get; set; }
        public string T6 { get; set; }
        public string T7 { get; set; }
        public string T8 { get; set; }
        public string T9 { get; set; }
        public string CostCenter { get; set; }
    }
}
