using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserGroupModuleTbl
    {
        public long UserGroupModuleId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserGroupId { get; set; }
        public long? AppMenuId { get; set; }
    }
}
