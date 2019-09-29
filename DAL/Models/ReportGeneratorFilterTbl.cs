using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ReportGeneratorFilterTbl
    {
        public long ReportGeneratorFilterId { get; set; }
        public long? ReportGeneratorId { get; set; }
        public int? ReportGeneratorFilterIndex { get; set; }
        public string ReportGeneratorFilterName { get; set; }
        public string ReportGeneratorFilterHeaderName { get; set; }
        public string ReportGeneratorFilterDataType { get; set; }
        public bool? ReportGeneratorFilterSysTableYn { get; set; }
        public string ReportGeneratorFilterAndOr { get; set; }
        public string ReportGeneratorFilterOperator { get; set; }
        public string ReportGeneratorFilterValue { get; set; }
        public bool? ReportGeneratorFilterChangeable { get; set; }
        public string ReportGeneratorFilterDisplayName { get; set; }
        public string ReportGeneratorControlType { get; set; }
        public string ReportGeneratorFilterDataTable { get; set; }
        public string ReportGeneratorFilterHeaderNameAr { get; set; }
        public string ReportGeneratorFilterDisplayNameAr { get; set; }
    }
}
