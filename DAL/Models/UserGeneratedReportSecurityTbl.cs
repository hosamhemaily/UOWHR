using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserGeneratedReportSecurityTbl
    {
        public long UserGeneratedReportSecurityId { get; set; }
        public long? UserId { get; set; }
        public long? PropertyId { get; set; }
        public long? GeneratedReportId { get; set; }
        public string GeneratedReportValuePath { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ReportGeneratorTbl GeneratedReport { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
