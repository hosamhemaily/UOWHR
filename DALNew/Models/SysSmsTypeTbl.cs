using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysSmsTypeTbl
    {
        public SysSmsTypeTbl()
        {
            SmsConfigurationTbl = new HashSet<SmsConfigurationTbl>();
        }

        public int SysSmsTypeId { get; set; }
        public int? SysSmsCategoryId { get; set; }
        public string SysSmsTypeEnName { get; set; }

        public virtual ICollection<SmsConfigurationTbl> SmsConfigurationTbl { get; set; }
    }
}
