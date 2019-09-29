using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class AutoNotificationTbl
    {
        public long AutoNotificationId { get; set; }
        public int? SysMessageTypeId { get; set; }
        public int? SysNotificationFieldId { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
    }
}
