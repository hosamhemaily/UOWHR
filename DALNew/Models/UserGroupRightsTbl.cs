using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserGroupRightsTbl
    {
        public long UserGroupRightsId { get; set; }
        public long PropertyId { get; set; }
        public long? UserId { get; set; }
        public long UserGroupId { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
