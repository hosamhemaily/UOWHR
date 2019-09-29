using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class UserFavoriteReportTbl
    {
        public long UserFavoriteReportId { get; set; }
        public long? UserId { get; set; }
        public long? PropertyId { get; set; }
        public long? SysReportId { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual SysReportTbl SysReport { get; set; }
        public virtual UserTbl User { get; set; }
    }
}
