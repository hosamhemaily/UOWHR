using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysReportParameterTbl
    {
        public long SysReportParameterId { get; set; }
        public long? SysReportId { get; set; }
        public string ParameterName { get; set; }
        public string ControlId { get; set; }
        public string ControlType { get; set; }

        public virtual SysReportTbl SysReport { get; set; }
    }
}
