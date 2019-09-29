using System;
using System.Collections.Generic;

namespace DALNew.Models
{
    public partial class UserGroupTbl
    {
        public long UserGroupId { get; set; }
        public long PropertyId { get; set; }
        public long? AppMenuId { get; set; }
        public string UserGroupCode { get; set; }
        public string UserGroupEnName { get; set; }
        public string UserGroupArName { get; set; }
        public string UserGroupArNameShadow { get; set; }
        public long? InsertUserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public long? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? MachineId { get; set; }
        public long? FormId { get; set; }
    }
}
