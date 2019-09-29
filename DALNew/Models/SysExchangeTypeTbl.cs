using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysExchangeTypeTbl
    {
        public SysExchangeTypeTbl()
        {
            EmailConfigurationTbl = new HashSet<EmailConfigurationTbl>();
        }

        public int SysExchangeTypeId { get; set; }
        public string SysExchangeTypeEnName { get; set; }
        public string SysExchangeTypeInternal { get; set; }

        public virtual ICollection<EmailConfigurationTbl> EmailConfigurationTbl { get; set; }
    }
}
