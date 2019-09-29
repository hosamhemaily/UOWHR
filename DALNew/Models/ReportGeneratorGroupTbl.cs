using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ReportGeneratorGroupTbl
    {
        public long ReportGeneratorGroupId { get; set; }
        public long? ReportGeneratorId { get; set; }
        public int? ReportGeneratorGroupIndex { get; set; }
        public string ReportGeneratorGroupFieldName { get; set; }
        public string ReportGeneratorGroupDisplayName { get; set; }
        public string ReportGeneratorGroupDisplayNameAr { get; set; }
    }
}
