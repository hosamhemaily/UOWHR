using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysReportTbl
    {
        public SysReportTbl()
        {
            SysReportFilterTbl = new HashSet<SysReportFilterTbl>();
            SysReportParameterTbl = new HashSet<SysReportParameterTbl>();
            UserFavoriteReportTbl = new HashSet<UserFavoriteReportTbl>();
            UserReportSecurityTbl = new HashSet<UserReportSecurityTbl>();
        }

        public long SysReportId { get; set; }
        public long? ParentId { get; set; }
        public long? CategoryId { get; set; }
        public long? ModuleId { get; set; }
        public string ReportValuePath { get; set; }
        public string SysReportEnName { get; set; }
        public string SysReportArName { get; set; }
        public string SysReportFileEnName { get; set; }
        public string SysReportFileArName { get; set; }
        public bool? HasFilterYn { get; set; }
        public bool? HasParameterYn { get; set; }
        public long? DisplayOrder { get; set; }
        public byte? LicenseTypeId { get; set; }
        public long? AppSettingId { get; set; }
        public bool? DisplayYn { get; set; }
        public bool? SubordinateYn { get; set; }
        public bool? ArabicReportReadyYn { get; set; }
        public string ReportFunction { get; set; }
        public bool? HistoryReportYn { get; set; }

        public virtual ICollection<SysReportFilterTbl> SysReportFilterTbl { get; set; }
        public virtual ICollection<SysReportParameterTbl> SysReportParameterTbl { get; set; }
        public virtual ICollection<UserFavoriteReportTbl> UserFavoriteReportTbl { get; set; }
        public virtual ICollection<UserReportSecurityTbl> UserReportSecurityTbl { get; set; }
    }
}
