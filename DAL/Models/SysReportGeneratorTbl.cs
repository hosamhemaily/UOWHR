using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysReportGeneratorTbl
    {
        public long SysReportGeneratorId { get; set; }
        public long? AppMenuId { get; set; }
        public string SysReportGeneratorEnName { get; set; }
        public string SysReportGeneratorArName { get; set; }
        public string SysReportGeneratorSource { get; set; }
        public string SysReportGeneratorQuery { get; set; }
        public string SysReportGeneratorFromQuery { get; set; }
    }
}
