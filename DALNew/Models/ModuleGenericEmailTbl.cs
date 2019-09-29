using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class ModuleGenericEmailTbl
    {
        public long ModuleGenericEmailId { get; set; }
        public long? PropertyId { get; set; }
        public int? SysEmailTypeId { get; set; }
        public string ModuleGenericEmailDisplayEnName { get; set; }
        public string ModuleGenericEmailAddress { get; set; }
        public string ModuleGenericEmailPassword { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }

        public virtual PropertyTbl Property { get; set; }
        public virtual SysEmailTypeTbl SysEmailType { get; set; }
    }
}
