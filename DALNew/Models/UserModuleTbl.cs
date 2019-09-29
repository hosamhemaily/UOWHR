using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserModuleTbl
    {
        public long UserModuleId { get; set; }
        public long? PropertyId { get; set; }
        public long? UserId { get; set; }
        public long? AppMenuId { get; set; }
        public string AllowedGrades { get; set; }

        public virtual PropertyTbl Property { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
