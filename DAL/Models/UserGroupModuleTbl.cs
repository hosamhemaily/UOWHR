using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserGroupModuleTbl
    {
        public long UserGroupModuleId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserGroupId { get; set; }
        public long? AppMenuId { get; set; }
    }
}
