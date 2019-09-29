using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class SysEmailTypeTbl
    {
        public SysEmailTypeTbl()
        {
            ModuleGenericEmailTbl = new HashSet<ModuleGenericEmailTbl>();
        }

        public int SysEmailTypeId { get; set; }
        public string SysEmailTypeEnName { get; set; }
        public string SysEmailTypeArName { get; set; }
        public long? AppSettingId { get; set; }

        public virtual ICollection<ModuleGenericEmailTbl> ModuleGenericEmailTbl { get; set; }
    }
}
