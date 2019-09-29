using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AppMenuReportTbl
    {
        public long AppMenuReportId { get; set; }
        public long? AppMenuId { get; set; }
        public long? SysReportId { get; set; }
        public string ReportType { get; set; }
        public string ReportLanguageEnAr { get; set; }
    }
}
