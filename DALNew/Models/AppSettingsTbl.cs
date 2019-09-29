using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AppSettingsTbl
    {
        public long AppSettingId { get; set; }
        public long PropertyId { get; set; }
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
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual AppSettingsMasterTbl AppSetting { get; set; }
    }
}
