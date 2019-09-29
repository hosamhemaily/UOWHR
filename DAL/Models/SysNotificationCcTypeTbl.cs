using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysNotificationCcTypeTbl
    {
        public int SysNotificationCcTypeId { get; set; }
        public string SysNotificationCcTypeCode { get; set; }
        public string SysNotificationCcTypeEnName { get; set; }
        public string SysNotificationCcTypeArName { get; set; }
        public long? AppSettingId { get; set; }
    }
}
