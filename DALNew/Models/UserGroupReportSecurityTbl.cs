using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserGroupReportSecurityTbl
    {
        public long UserGroupReportSecurityId { get; set; }
        public long? UserGroupId { get; set; }
        public long? SysReportId { get; set; }
        public string ReportValuePath { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
