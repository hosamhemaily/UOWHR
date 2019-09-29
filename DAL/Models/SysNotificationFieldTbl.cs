using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysNotificationFieldTbl
    {
        public int SysNotificationFieldId { get; set; }
        public string SysNotificationFieldCode { get; set; }
        public string SysNotificationFieldEnName { get; set; }
        public string SysNotificationFieldArName { get; set; }
        public long? AppSettingId { get; set; }
    }
}
