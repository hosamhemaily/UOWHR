using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AppSettingsMasterTbl
    {
        public AppSettingsMasterTbl()
        {
            AppSettingsTbl = new HashSet<AppSettingsTbl>();
        }

        public long AppSettingMasterId { get; set; }
        public long? AppMenuId { get; set; }
        public string AppGroup { get; set; }
        public string AppGroupAr { get; set; }
        public string AppGroupType { get; set; }
        public string AppCode { get; set; }
        public int? AppDisplayOrder { get; set; }
        public string AppShortDescription { get; set; }
        public string AppShortDescriptionAr { get; set; }
        public string AppLongDescription { get; set; }
        public string AppLongDescriptionAr { get; set; }
        public string AppParaValue { get; set; }
        public string AppActiveRule { get; set; }
        public string FromTableName { get; set; }
        public string PropertyRelatedYn { get; set; }
        public string AppDisplayYn { get; set; }
        public string AppControl { get; set; }
        public string AppControlType { get; set; }
        public int? FieldLength { get; set; }

        public virtual ICollection<AppSettingsTbl> AppSettingsTbl { get; set; }
    }
}
