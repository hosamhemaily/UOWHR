using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ReportGeneratorTbl
    {
        public ReportGeneratorTbl()
        {
            UserGeneratedReportSecurityTbl = new HashSet<UserGeneratedReportSecurityTbl>();
        }

        public long ReportGeneratorId { get; set; }
        public long? PropertyId { get; set; }
        public long? AppMenuId { get; set; }
        public string ReportGeneratorEnName { get; set; }
        public string ReportGeneratorArName { get; set; }
        public string ReportGeneratorArNameShadow { get; set; }
        public string ReportGeneratorTitleName { get; set; }
        public string ReportGeneratorLanguage { get; set; }
        public string ReportGeneratorOrientation { get; set; }
        public bool? ReportHeaderAttributeBoldYn { get; set; }
        public bool? ReportHeaderAttributeItalicYn { get; set; }
        public bool? ReportHeaderAttributeUnderlineYn { get; set; }
        public string ReportGeneratorDataSource { get; set; }
        public string ReportGeneratorSelectStatment { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual ICollection<UserGeneratedReportSecurityTbl> UserGeneratedReportSecurityTbl { get; set; }
    }
}
