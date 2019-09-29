using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ReportGeneratorFieldTbl
    {
        public long ReportGeneratorFieldId { get; set; }
        public long? ReportGeneratorId { get; set; }
        public int? ReportGeneratorFieldIndex { get; set; }
        public string ReportGeneratorFieldHeaderName { get; set; }
        public string ReportGeneratorFieldName { get; set; }
        public string ReportGeneratorFieldDataType { get; set; }
        public bool? ReportGeneratorFieldSysTableYn { get; set; }
        public string ReportGeneratorFieldAlign { get; set; }
        public string ReportGeneratorFieldSummary { get; set; }
        public string ReportGeneratorFieldHeaderNameAr { get; set; }
    }
}
