using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysRequestTypeTbl
    {
        public SysRequestTypeTbl()
        {
            SelfServiceRequestTbl = new HashSet<SelfServiceRequestTbl>();
        }

        public int SysRequestTypeId { get; set; }
        public string SysRequestTypeEnName { get; set; }
        public string SysRequestTypeArName { get; set; }
        public long? AppSettingId { get; set; }
        public bool? SubordinateYn { get; set; }
        public string SysRequestTypeTableName { get; set; }

        public virtual ICollection<SelfServiceRequestTbl> SelfServiceRequestTbl { get; set; }
    }
}
