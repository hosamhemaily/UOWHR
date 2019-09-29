using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysReportGeneratorFieldNameTbl
    {
        public long SysReportGeneratorFieldNameId { get; set; }
        public string SysReportGeneratorViewName { get; set; }
        public string SysReportGeneratorFieldName { get; set; }
        public string SysReportGeneratorDisplayEnName { get; set; }
        public string SysReportGeneratorDisplayArName { get; set; }
        public bool? SysTableYn { get; set; }
    }
}
