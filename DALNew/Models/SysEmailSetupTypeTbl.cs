using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysEmailSetupTypeTbl
    {
        public SysEmailSetupTypeTbl()
        {
            EmailConfigurationTbl = new HashSet<EmailConfigurationTbl>();
        }

        public int SysEmailSetupTypeId { get; set; }
        public string SysEmailSetupTypeEnName { get; set; }
        public string SysEmailSetupTypeArName { get; set; }

        public virtual ICollection<EmailConfigurationTbl> EmailConfigurationTbl { get; set; }
    }
}
