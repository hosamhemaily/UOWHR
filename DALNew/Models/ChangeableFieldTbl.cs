using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ChangeableFieldTbl
    {
        public ChangeableFieldTbl()
        {
            ChangeOfStatusDetailsTbl = new HashSet<ChangeOfStatusDetailsTbl>();
        }

        public long ChangeableFieldId { get; set; }
        public string ChangeableFieldCode { get; set; }
        public string ChangeableFieldEnName { get; set; }
        public string ChangeableFieldArName { get; set; }
        public string ChangeableControlName { get; set; }
        public string ChangeableControlType { get; set; }
        public int? SortId { get; set; }
        public string BatchStatus { get; set; }
        public long? AppSettingId { get; set; }
        public bool? SelfServiceYn { get; set; }

        public virtual ICollection<ChangeOfStatusDetailsTbl> ChangeOfStatusDetailsTbl { get; set; }
    }
}
