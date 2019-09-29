using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SmsConfigurationTbl
    {
        public long SmsConfigurationId { get; set; }
        public long? PropertyId { get; set; }
        public int? SysSmsTypeId { get; set; }
        public string SmsConfigurationEnName { get; set; }
        public int? SmsConfigurationUsbPort { get; set; }
        public int? SmsConfigurationUsbBaudRate { get; set; }
        public int? SmsConfigurationUsbTimeOut { get; set; }
        public bool? SmsConfigurationUsbAlertYn { get; set; }
        public bool? SmsConfigurationUsbUnicodeYn { get; set; }
        public string SysSmsConfigurationUserName { get; set; }
        public string SysSmsConfigurationPassword { get; set; }
        public string InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
        public string SysSmsConfigurationApi { get; set; }
        public string SmsConfigurationGetwayMobileNumber { get; set; }
        public string SmsConfigurationUsbMobileNumber { get; set; }

        public virtual PropertyTbl Property { get; set; }
        public virtual SysSmsTypeTbl SysSmsType { get; set; }
    }
}
