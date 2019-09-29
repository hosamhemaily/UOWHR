using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class EmailConfigurationTbl
    {
        public long EmailConfigurationId { get; set; }
        public long? PropertyId { get; set; }
        public int? SysEmailSetupTypeId { get; set; }
        public int? SysExchangeTypeId { get; set; }
        public string EmailExchangeUrl { get; set; }
        public int? EmailPortNo { get; set; }
        public bool? EmailUseSslYn { get; set; }
        public string EmailSmtp { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual PropertyTbl Property { get; set; }
        public virtual SysEmailSetupTypeTbl SysEmailSetupType { get; set; }
        public virtual SysExchangeTypeTbl SysExchangeType { get; set; }
    }
}
