using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AppMenuTbl
    {
        public AppMenuTbl()
        {
            UserFormSecurityTbl = new HashSet<UserFormSecurityTbl>();
        }

        public long AppMenuId { get; set; }
        public string AppMenuType { get; set; }
        public string AppMenuEnName { get; set; }
        public string AppMenuArName { get; set; }
        public string AppMenuTableName { get; set; }
        public int? ParentId { get; set; }
        public string AppMenuValuePath { get; set; }
        public string ScreenUrlEn { get; set; }
        public string ScreenUrlAr { get; set; }
        public string ScreenImgEn { get; set; }
        public string ScreenImgAr { get; set; }
        public int? DisplayOrder { get; set; }
        public byte? LicenseTypeId { get; set; }
        public long? AppSettingId { get; set; }
        public bool? SubordinateYn { get; set; }
        public long? ModuleId { get; set; }
        public bool? DisplayYn { get; set; }
        public bool? ViewYn { get; set; }
        public bool? InsertYn { get; set; }
        public bool? UpdateYn { get; set; }
        public bool? DeleteYn { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }

        public virtual LicenseTypeTbl LicenseType { get; set; }
        public virtual ICollection<UserFormSecurityTbl> UserFormSecurityTbl { get; set; }
    }
}
