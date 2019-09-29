using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class NotificationConfigurationTbl
    {
        public long NotificationConfigurationId { get; set; }
        public long? PropertyId { get; set; }
        public int? SysNotificationFieldId { get; set; }
        public string EmailMessage { get; set; }
        public string CcEmail { get; set; }
        public string AnotherEmail { get; set; }
        public string SmsMessage { get; set; }
        public string CcSms { get; set; }
        public bool? SendEmailsAutomaticallyYn { get; set; }
        public int? SendEmailBeforeEventByXDays { get; set; }
        public int? RepeatSendingEmailsEveryXDays { get; set; }
        public int? SendEmailAtXOclock { get; set; }
        public bool? SendSmsAutomaticallyYn { get; set; }
        public int? SendSmsBeforeEventByXDays { get; set; }
        public int? RepeatSendingSmsEveryXDays { get; set; }
        public int? SendSmsAtXOclock { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
